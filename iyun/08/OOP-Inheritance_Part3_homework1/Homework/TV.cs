using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public sealed class TV : Item
    {
        public bool IsSmartTv { get; set; }
        public bool HasHDMI { get; set; }
        public int Resolution { get; set; }
    }
}
