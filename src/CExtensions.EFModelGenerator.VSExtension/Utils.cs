using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.VSExtension
{
    public class Utils
    {
        public static UIHierarchyItem GetSelectedItem(DTE2 dte)
        {
            var items = (Array)dte.ToolWindows.SolutionExplorer.SelectedItems;

            foreach (UIHierarchyItem selItem in items)
            {
                return selItem;
            }

            return null;
        }

        public static ProjectItem GetSelectedProjectItem(DTE2 dte)
        {
            return dte?.SelectedItems?.Item(1)?.ProjectItem;
        }

        public static string GetItemProjectPath(ProjectItem item)
        {
            return Path.GetDirectoryName(item.ContainingProject.FullName);
        }

       


    }
}
