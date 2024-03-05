using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Truck:Vehicle
    {
        public string Company { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", Id, Name, Manufacture, Price, Year, Type);
        }
        public static IList<Truck> Trucks
        {
            get
            {
                return new List<Truck>
        {     
            new Truck { Id = 1, Name = "Truck1", Manufacture = 1995, Price = 500324, Year = 2003, Type = "small", Company="Honda" },
            new Truck { Id = 2, Name = "Truck2", Manufacture = 2000, Price = 502340, Year = 2003, Type = "medium",Company="Toyota" },
            new Truck { Id = 3, Name = "Truck3", Manufacture = 2005, Price = 5100, Year = 2003, Type = "large",Company="BMW" },
            new Truck { Id = 4, Name = "Truck4", Manufacture = 2010, Price = 52200, Year = 2003, Type = "extra large",Company="Huyndai" },
            new Truck { Id = 5, Name = "Truck5", Manufacture = 2015, Price = 53300, Year = 2003, Type = "giant" ,Company="Honda"}
        };
            }
        }
    }
}
