using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._4
{
    internal class Coffee: Beverages
    {
        public string Strength { get; set; }

        public Coffee(string size, string temperature, string strength) 
        {
            Size = size;
            Temperature = temperature;
            Strength = strength;
        }
    }
}
