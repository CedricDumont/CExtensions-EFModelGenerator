using CExtensions.EFModelGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExtensions.EFModelGenerator
{
    public class InverseProperty : IInverseProperty
    {
        public String ReversePropertyName { get; set; }

        public String PropertyName { get; set; }

        public String ReverseCLRType { get; set; }


    }

}
