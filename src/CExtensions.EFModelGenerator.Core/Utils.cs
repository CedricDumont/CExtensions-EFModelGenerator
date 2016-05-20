using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator.Core
{
    public sealed class Utils
    {
        public static String Pluralize(String s)
        {
            return s.Pluralize();
        }

        public static Object CallMethodOnObject(Object obj, string method, Object[] mparams)
        {
            MethodInfo myMethod = obj.GetType().GetMethod(method, BindingFlags.FlattenHierarchy);

            if (myMethod == null)
            {
                throw new Exception($"Could not find method: {method} in {obj.GetType()}");
            }

            return myMethod.Invoke(obj, mparams);


        }

    }

   
}
