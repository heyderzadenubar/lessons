using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Part3_homework1
{
   public sealed class TV : Base
    {
        public bool IsSmartTv { get; set; }
        public bool HasHDMI { get; set; }
        public string Resolution { get; set; }
    }
}
