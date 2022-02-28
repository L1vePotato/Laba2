using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int A;
            //int B;
            //string X;
            
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Режимы: Сложение +, вычитание -, умножение *, деление /");
            string X = Convert.ToString(Console.ReadLine());
            string Plus;
            string Minus;
            string Umnoj;
            string Razdel;

            int C = A + B;

            Console.WriteLine("Ответ");
            Console.WriteLine(C);
            Console.ReadKey();

        }
    }
}
