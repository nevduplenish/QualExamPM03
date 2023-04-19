using System;
using System.IO;
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

        //алгоритм сортировки по убыванию двух свойств 
        public void SortByManufacturerAndPriceDescending()
        {
            for (int i = 0; i < _apps.Length - 1; i++)
            {
                for (int j = 0; j < _apps.Length - 1 - i; j++)
                {
                    int compareByManufacturer = _apps[j + 1].Manufacturer.CompareTo(_apps[j].Manufacturer);
                    if (compareByManufacturer > 0 || (compareByManufacturer == 0 && _apps[j + 1].Price > _apps[j].Price))
                    {
                        App temp = _apps[j];
                        _apps[j] = _apps[j + 1];
                        _apps[j + 1] = temp;
                    }
                }
            }
        }

        //метод для сохранения отсортированного массива в файл
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (App app in _apps)
                {
                    writer.WriteLine($"{app.Name},{app.Manufacturer},{app.Price}");
                }
            }
        }
    }


}


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

