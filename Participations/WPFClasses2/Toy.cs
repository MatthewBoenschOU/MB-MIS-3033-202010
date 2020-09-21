using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClasses2
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle { get; set; }

        public Toy ()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }
        
        public string GetAisle()
        {
            string AName = $"{Manufacturer.Substring(0, 1).ToUpper()}{Price.ToString()}";
            return AName;
        }
    }
}
