using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Car : Vehicle
    {


        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", Id, Name, Manufacture, Price, Year, Type);
        }

        public static IList<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Id = 1, Name = "Honda", Manufacture = 2000, Price = 5004324, Year = 1990, Type = "big" },
                    new Car { Id = 2, Name = "Toyota", Manufacture = 2018, Price = 245632, Year = 2003, Type = "big" },
                    new Car { Id = 3, Name = "Mazda", Manufacture = 1925, Price = 500234, Year = 2003, Type = "small" },
                    new Car { Id = 4, Name = "VinFast", Manufacture = 2017, Price = 50033, Year = 2003, Type = "medium" },
                    new Car { Id = 5, Name = "KIA", Manufacture = 2019, Price = 50044, Year = 2003, Type = "big" },
                    new Car { Id = 6, Name = "BMW", Manufacture = 1946, Price = 222500, Year = 1900, Type = "big" },
                    new Car { Id = 7, Name = "Merc", Manufacture = 1981, Price = 443500, Year = 2011, Type = "large" },
                    new Car { Id = 8, Name = "BMW", Manufacture = 1920, Price = 2342500, Year = 1899, Type = "big" },
                    new Car { Id = 9, Name = "VinFast", Manufacture = 1940, Price = 22222500, Year = 2003, Type = "small" },
                    new Car { Id = 10, Name = "BMW", Manufacture = 1944, Price = 244324500, Year = 2003, Type = "big" }
                };

            }
        }
    }
}

