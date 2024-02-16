using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Попов";
            string surname = "Георгий";

            Console.WriteLine($"Ваше имя {name}, ваша фамилия {surname}");

            string temp;
            temp = name;
            name = surname;
            surname = temp;

            Console.WriteLine($"Прошу прощения, исправляю. Ваше имя {name}, ваша фамилия {surname}");
        }
    }
}
