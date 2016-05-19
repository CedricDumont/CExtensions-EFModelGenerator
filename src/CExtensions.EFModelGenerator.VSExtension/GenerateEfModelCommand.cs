//------------------------------------------------------------------------------
// <copyright file="GenerateEfModelCommand.cs" company="Licence Owner">
//     Copyright (c) Licence Owner.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System.Diagnostics;
using Microsoft.VisualStudio;
using System.IO;
using System.Runtime.InteropServices;
using EnvDTE80;
using EnvDTE;
using CExtensions.EFModelGenerator.Common;
using CExtensions.EFModelGenerator.Core;

namespace CExtensions.EFModelGenerator.VSExtension
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class GenerateEfModelCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("9568d8a5-a9e3-4fdd-8428-7def7f6660da");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateEfModelCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private GenerateEfModelCommand(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new OleMenuCommand(this.MenuItemCallback, menuCommandID);
                commandService.AddCommand(menuItem);
            }
        }

       

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static GenerateEfModelCommand Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {

            Instance = new GenerateEfModelCommand(package);
        }

        public static bool IsSingleProjectItemSelection(out IVsHierarchy hierarchy, out uint itemid)
        {
            var dte2 = (DTE2)Package.GetGlobalService(typeof(SDTE));

            Debug.WriteLine("in IsSingleProjectItemSelection " + dte2.SelectedItems.Count);
            hierarchy = null;
            itemid = VSConstants.VSITEMID_NIL;
            int hr = VSConstants.S_OK;

            var monitorSelection = Package.GetGlobalService(typeof(SVsShellMonitorSelection)) as IVsMonitorSelection;
            var solution = Package.GetGlobalService(typeof(SVsSolution)) as IVsSolution;
            if (monitorSelection == null || solution == null)
            {
                return false;
            }

            IVsMultiItemSelect multiItemSelect = null;
            IntPtr hierarchyPtr = IntPtr.Zero;
            IntPtr selectionContainerPtr = IntPtr.Zero;

            try
            {
                hr = monitorSelection.GetCurrentSelection(out hierarchyPtr, out itemid, out multiItemSelect, out selectionContainerPtr);

                if (ErrorHandler.Failed(hr) || hierarchyPtr == IntPtr.Zero || itemid == VSConstants.VSITEMID_NIL)
                {
                    // there is no selection
                    return false;
                }

                // multiple items are selected
                if (multiItemSelect != null) return false;

                // there is a hierarchy root node selected, thus it is not a single item inside a project

                if (itemid == VSConstants.VSITEMID_ROOT) return false;

                hierarchy = Marshal.GetObjectForIUnknown(hierarchyPtr) as IVsHierarchy;
                if (hierarchy == null) return false;

                Guid guidProjectID = Guid.Empty;

                if (ErrorHandler.Failed(solution.GetGuidOfProject(hierarchy, out guidProjectID)))
                {
                    return false; // hierarchy is not a project inside the Solution if it does not have a ProjectID Guid
                }

                // if we got this far then there is a single project item selected
                return true;
            }
            finally
            {
                if (selectionContainerPtr != IntPtr.Zero)
                {
                    Marshal.Release(selectionContainerPtr);
                }

                if (hierarchyPtr != IntPtr.Zero)
                {
                    Marshal.Release(hierarchyPtr);
                }
            }
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            var _dte = (DTE2)Package.GetGlobalService(typeof(SDTE));
            
            ProjectItem projectItem = Utils.GetSelectedProjectItem(_dte);

            if (projectItem == null)
                return;

            string projectPath = Utils.GetItemProjectPath(projectItem);

            string fileContent =  File.ReadAllText(projectItem.Document.FullName);

            EFMGSettings settings = EFMGSettings.Build(fileContent);

            String FileName = projectItem.Document.Name;

            if (settings.FilePath != null)
            {
                FileName = settings.FilePath;
            }

            //ensure csharp file
            FileName = FileName.EndsWith(".cs") ? FileName : FileName + ".cs";

            string newFilePath = Path.Combine(projectPath, FileName);

            if(File.Exists(newFilePath))
            {
                File.Delete(newFilePath);
            }

            using (var tw = File.CreateText(newFilePath))
            {
                tw.WriteLine("hello");
                //GenerationOptions options = new GenerationOptions();
                //Generator generator = new Generator(options);
                //generator.Generate(tw);
            }

            ProjectItem item = projectItem.ContainingProject.ProjectItems.AddFromFile(newFilePath);

        }

         
    }
}
