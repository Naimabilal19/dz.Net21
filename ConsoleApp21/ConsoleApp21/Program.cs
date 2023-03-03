using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Poem: IDisposable
    {
        string name { get; set; }
        string fio { get; set; }
        string ganre { get; set; }
        int year { get; set; }

        public Poem() { }
        public Poem(string n, string f, string g, int y) { name = n;fio = f;ganre = g;year = y; }

        public void Print()
        {
            Console.WriteLine($"name:{name} \nfio: {fio}\nganre: {ganre}\nyear: {year}\n");
        }
        public void Dispose()
        {
            Console.WriteLine("Function 'Dispose' was done");
        }
        ~Poem()
        {
            Console.WriteLine("Object was deleted(~)");
        }
    }

    class Shop: IDisposable
    {
        string name { get; set; }
        string address { get; set; }
        string type { get; set; }
        public Shop() { }
        public Shop(string n, string a, string t) { name = n;address = a;type = t; }

        public void Print()
        {
            Console.WriteLine($"Name: {name}\nAddress: {address}\n Type: {type}\n");
        }
        public void Dispose()
        {
            Console.WriteLine("Function 'Dispose' was done");
        }
        ~Shop()
        {
            Console.WriteLine("Object was deleted(~)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Poem p = new Poem("Ревизор", "Николай Гоголь", "Комедия", 1836);
            p.Print();
            p.Dispose();

            Shop s = new Shop("Копейка", "Малиновского 27а", "Продуктовый магазин");
            s.Print();
            s.Dispose();
        }
    }
}
