using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
/// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
/// </summary>
namespace PresnikovSA.App1
{
    //Делегат
    public delegate double FunDel(double a, double x);


    class Program
    {/// <summary>Метод, принимающий делегат</summary>
     /// <param name="(FunDel">Метод с сигнатурой double, double, double</param>
     /// <param name="a">Параметр "а"</param>
     /// <param name="x">Параметр "х"</param>
     /// <param name="b">Количество строк в таблице</param>
        public static void Table (FunDel fundel, double a, double x, double b)
        {
            Console.WriteLine("--------A----------X----------Y-----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000}|", a, x, fundel(a,x));
                x += 1;
            }
            Console.WriteLine("-------------------------------------");
        }
        public static double Func1(double a, double x)
        {
            return a * x * x;
        }
        public static double Func2(double a, double x)
        {
            return a * Math.Sin(x);
        }
        static void Main()
        {
            Console.WriteLine("Функция а* х^2");
            Table(new FunDel(Func1), -2, 2, 5);


            Console.WriteLine("Функция а* Sin(x)");
            Table(new FunDel(Func2), -4, -2, 2);

            Console.ReadKey();
        }
    }
}
