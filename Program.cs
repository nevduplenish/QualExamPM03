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


        //в конструкторе класса создается массив объектов типа App
        public Applications(int size)
        {
            _apps = new App[size];
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
