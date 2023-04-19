using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qualExamPM03
{
    struct App
    {
        public string Name;
        public string Manufacturer;
        public int Price;
    }

    class Applications
    {
        private App[] _apps;


        //в конструкторе класса создается массив указателей на экземпляры типа App
        public Applications(int size)
        {
            _apps = new App[size];
        }


        //метод для заполнения массива пользователем
        public void FillArray()
        {
            for (int i = 0; i < _apps.Length; i++)
            {
                Console.Write($"Enter name of app {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter manufacturer of app {i + 1}: ");
                string manufacturer = Console.ReadLine();
                Console.Write($"Enter price of app {i + 1}: ");
                int price = int.Parse(Console.ReadLine());

                _apps[i] = new App
                {
                    Name = name,
                    Manufacturer = manufacturer,
                    Price = price
                };
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
