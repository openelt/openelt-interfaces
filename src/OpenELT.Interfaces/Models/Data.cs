using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OpenELT.Interfaces.Models
{
    public class Data
    {
        public IEnumerable<object> Tuples { get; set; }
        public Dictionary<string, Type> Structure { get; set; }
    }
}