
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
namespace Producer
{
    public class DataBild
    {
        public string Name;
        public string date;
        public string age;
        public string profession;

        public DataBild()
        {
            Console.WriteLine("Enter Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter date:");
            this.date = Console.ReadLine();
            Console.WriteLine("Enter age:");
            this.age = Console.ReadLine();
            Console.WriteLine("Enter profession:");
            this.profession = Console.ReadLine();
        }
    }
}
