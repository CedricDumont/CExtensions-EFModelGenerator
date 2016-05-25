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
using CExtensions.EFModelGenerator;

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

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            try
            {
                //get the selected item and some more info
                var _dte = (DTE2)Package.GetGlobalService(typeof(SDTE));

                ProjectItem projectItem = Utils.GetSelectedProjectItem(_dte);

                if (projectItem == null)
                    return;

                //init some props
                string projectPath = Utils.GetItemProjectPath(projectItem);
                String selectedItemFullPath = (string)projectItem.Properties.Item("FullPath").Value;

                string fileContent = File.ReadAllText(selectedItemFullPath);
                EFMGSettings settings = EFMGSettings.Build(fileContent);

                if (settings.Options.ImplementingClassPath == null)
                {
                    settings.Options.ImplementingClassPath = Path.Combine(projectPath, "bin", "Debug");
                }

                var resultFile = Generator.Generate(settings);

                ProjectItem item = projectItem.ContainingProject.ProjectItems.AddFromFile(resultFile);

            }
            catch(Exception ex)
            {
                throw new Exception("An error occured while generating the sources : " + ex.Message, ex);
            }

        }         
    }
}
