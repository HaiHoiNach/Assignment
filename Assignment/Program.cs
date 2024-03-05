using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var cars = Car.Cars;
            Console.WriteLine("Danh sach xe:");

            var firstlist = from item in cars select item;
            foreach (var item in firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Cau 2a: Hiển thị các xe có giá trong khoảng 100.000 đến 250.000 ");

            var list = from item in cars where item.Price > 100000 && item.Price < 250000 select item.Name;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Cau 2b: Các xe có năm sản xuất > 1990");
            var list1 = from item in cars where item.Manufacture > 1900 select item.Name;

            foreach (var item in list1)
            {
                Console.Write(item+", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cau 2c: Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm");
            //var list2 = from item in cars.GroupBy(group  where  select item.Name;
            var list2 = cars.GroupBy(car => car.Name).Select(group => new
            {
                car = group.Key,
                TotalSales = group.Sum(car => car.Price)
            });

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Cau 3a: Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất");
            var trucks = Truck.Trucks;

            var sortedTrucks = trucks.OrderByDescending(t => t.Manufacture);
            foreach (var item in sortedTrucks)
            {
                Console.WriteLine($"Name: {item.Name}, Năm sản xuất:{item.Manufacture}");
            }
            Console.WriteLine();
            Console.WriteLine("Cau 3b: Hiển thị tên cty chủ quản của Truck");
            Console.WriteLine();
            foreach (var item in trucks)
            {
                Console.WriteLine($"Name: {item.Name}, công ty chủ quản :{item.Company}");
            }
            Console.ReadKey();

        }
    }
}
