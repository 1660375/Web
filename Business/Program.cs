
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace Business
{
    class Program
    {
        public static QLDTEntities db = new QLDTEntities();
        class Person
        {
            public string Name { get; set; }
        }
        class Pet
        {
            public string Name { get; set; }
            public Person Owner { get; set; }
        }
        class Categories // Lớp Categories chứa danh sách các sản phẩm
        {
            public List<string> Products { get; set; }
        }
        static void Main(string[] args)
        {
            var a = db.GIAOVIENs;
            var x = a.Where(p => p.LUONG > 2000);
            var y = a.SelectMany(p => p.MABM);
            foreach (char item in y)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
