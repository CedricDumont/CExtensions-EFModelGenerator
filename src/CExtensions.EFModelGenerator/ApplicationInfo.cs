﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public class ApplicationInfo
    {
        public static bool TestMode = false;

        public string _generationInfo;

        public string GenerationInfo
        {
            get
            {
                if (_generationInfo == null)
                {
                    StringBuilder sb = new StringBuilder();

                   
                    if (!TestMode)
                    {
                        sb.AppendLine($"// This code was generated with {GeneratingMutatingAssemblyInfo()}");
                    }
                    sb.AppendLine(@"// please visit : https://github.com/CedricDumont/CExtensions-EFModelGenerator");
                    sb.AppendLine($"// Copyright © Cedric Dumont 2016 (http://www.cedric-dumont.com)");

                    _generationInfo = sb.ToString();
                }

                return _generationInfo;
            }

        }

        private String GeneratingMutatingAssemblyInfo()
        {
            if (TestMode)
            {
                return "[Generation in test mode : mutating info skipped]";
            }

            try
            {
                var assemblyName = Assembly.GetExecutingAssembly().GetName().FullName;
                var informationalVersion = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

                return $"{ assemblyName} - {informationalVersion} [on { DateTime.Now}]";
            }
            catch (Exception ex)
            {
                return $"Error while getting assembly info : {ex.Message}";
            }
        }

        public String FormatException(Exception ex, GenerationOptions options)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------------------------------------------------------------");
            sb.AppendLine("Oups !! An exception occured while generating the code !");
            sb.AppendLine($"Go to  https://github.com/CedricDumont/CExtensions-EFModelGenerator to check for known issues");
            sb.AppendLine("Or open an issue with the following Information : ");
            sb.AppendLine("");
            sb.AppendLine("***********************************************************");
            sb.AppendLine("");
            sb.AppendLine($"- Generation Module Info : {GeneratingMutatingAssemblyInfo()}");
            sb.AppendLine("");
            sb.AppendLine($"- Generation steps :");
            sb.AppendLine($"{_GenerationSteps.ToString()}");
            sb.AppendLine("");
            sb.AppendLine("- Options:");
            sb.AppendLine($"{JsonConvert.SerializeObject(options, Formatting.Indented)}");
            sb.AppendLine("");
            sb.AppendLine("- Exception Details:");
            sb.AppendLine($"Message : {ex.Message}");
            if (!TestMode) { sb.AppendLine($"Stack : {Environment.NewLine}{ex.StackTrace}"); }

            if (ex.InnerException != null)
            {
                sb.AppendLine("");
                sb.AppendLine($"Inner Exception Message : {ex.Message}");
                if (!TestMode) { sb.AppendLine($"Inner Exception Stack :{Environment.NewLine} {ex.StackTrace}"); }
            }
            sb.AppendLine("");
            sb.AppendLine("***********************************************************");

            return sb.ToString();
        }

        public StringBuilder _GenerationSteps = new StringBuilder();

        private int stepCounter = 0;
        public void AddStep(string stepInfo)
        {
            stepCounter++;
            _GenerationSteps.AppendLine($"   {stepCounter}: {stepInfo}");
        }
    }
}
