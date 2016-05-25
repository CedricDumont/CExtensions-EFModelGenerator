using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public sealed class Utils
    {
        public static String Pluralize(String s)
        {
            return s.Pluralize();
        }

        public static Object CallMethodOnObject(Object obj, string method, Object[] mparams)
        {
            MethodInfo myMethod = obj.GetType().GetMethod(method);

            if (myMethod == null)
            {
                myMethod = obj.GetType().BaseType.GetMethod(method);

                if (myMethod == null)
                {
                    throw new Exception($"Could not find method: {method} in {obj.GetType()} or in basetype");
                }
            }

            return myMethod.Invoke(obj, mparams);


        }

    }

   
}
