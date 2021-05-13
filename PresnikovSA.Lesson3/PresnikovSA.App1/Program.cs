using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresnikovSA.App1
{
    class Complex
    {
        static int MistEnt()
        {
            int x;
            while (true)
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Введено не числовое значение.Пожалуйста, повторите ввод: ");
                }

                else return x;
        }

        private double im;
        private double re;


        public Complex(double re, double im)
        {

            this.re = re;
            this.im = im;

        }

        public Complex Plus(Complex x)
        {
            return new Complex(re + x.re, im + x.im);
        }

        public Complex Minus(Complex x)
        {
            return new Complex(re - x.re, im - x.im);
        }

        public Complex MultiP(Complex x)
        {
            return new Complex(re * x.re - im * x.im, re * x.im + im * x.re);
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        class Program
        {
            struct Complex
            {
                public double im;
                public double re;
                public Complex(double re, double im)
                {
                    this.re = re;
                    this.im = im;
                }
                public Complex Plus(Complex x)
                {
                    Complex y;
                    y.re = re + x.re;
                    y.im = im + x.im;
                    return y;
                }
                public Complex Minus(Complex x)
                {
                    Complex y;
                    y.re = re - x.re;
                    y.im = im - x.im;
                    return y;
                }

                public Complex MultiP(Complex x)
                {
                    Complex y;
                    y.re = re * x.re - im * x.im;
                    y.im = re * x.im + im * x.re;
                    return y;
                }



                public override string ToString()
                {
                    return $"{re} + {im}i";
                }



                private static int MistEnt()
                {
                    int x;
                    while (true)
                        if (!int.TryParse(Console.ReadLine(), out x))
                        {
                            Console.Write("Введено не числовое значение.Пожалуйста, повторите ввод: ");
                        }

                        else return x;
                }
            }
            static void Task1()
            {
                //Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
                Complex complex01;
                Console.WriteLine("Введите первое число :  ");
                Console.Write(" re = ");
                complex01.re = double.Parse(Console.ReadLine());
                Console.Write(" im = ");
                complex01.im = double.Parse(Console.ReadLine());
                Console.WriteLine($"Первое комплексное число: {complex01}");

                Complex complex02;
                Console.WriteLine("Введите второе число :  ");
                Console.Write(" re = ");
                complex02.re = double.Parse(Console.ReadLine());
                Console.Write(" im = ");
                complex02.im = double.Parse(Console.ReadLine());
                Console.WriteLine($"Второе комплексное число: {complex02}");

                Complex complex03 = complex01.Plus(complex02);
                Console.WriteLine($"Результат сложения комплексных чисел: {complex03}");

                Complex complex04 = complex01.Minus(complex02);
                Console.WriteLine($"Результат вычитания комплексных чисел: {complex04}");

                Complex complex05 = complex01.MultiP(complex02);
                Console.WriteLine($"Результат произведения комплексных чисел: {complex05}");

                Console.ReadKey();


            }
            static void Task2()
            {//Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
                Complex complex01 = new Complex(0, 0); ;
                Console.WriteLine("Введите первое число :  ");
                Console.Write(" re = ");
                complex01.re = double.Parse(Console.ReadLine());
                Console.Write(" im = ");
                complex01.im = double.Parse(Console.ReadLine());
                Console.WriteLine($"Первое комплексное число: {complex01}");

                Complex complex02 = new Complex(0, 0);
                Console.WriteLine("Введите первое число :  ");
                Console.Write(" re = ");
                complex02.re = double.Parse(Console.ReadLine());
                Console.Write(" im = ");
                complex02.im = double.Parse(Console.ReadLine());
                Console.WriteLine($"Второе комплексное число: {complex02}");


                Complex complex03 = complex01.Plus(complex02);
                Complex complex04 = complex01.Minus(complex02);


                Console.WriteLine($"Результат сложения комплексных чисел: {complex03}");
                Console.WriteLine($"Результат вычитания комплексных чисел: {complex04}");

                Console.ReadKey();


            }
            static void Task3()
            {//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
             //Требуется подсчитать сумму всех нечётных положительных чисел.
             //Сами числа и сумму вывести на экран, используя tryParse.
                Console.WriteLine("Введите числа ( для завершения работы введите 0) : ");

                int a = 0;
                while (true)
                {
                    int b = MistEnt();
                    if (b == 0)
                    {
                        break;
                    }
                    else if (b > 0 && b % 2 == 1)
                    {
                        a += b;
                    }
                }

                Console.WriteLine($"Сумма нечетных чисел = {a}");

                Console.ReadLine();



            }

            static void Main(string[] args)
            {
                int number;
                do
                {
                    Console.WriteLine("Введите номер задания - 1 (1a),2 (1b), 3:  ");
                    Console.WriteLine("Введите 0 - для завершения работы программы:  ");
                    number = int.Parse(Console.ReadLine());

                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("Завершение работы программы");
                            break;

                        case 1:
                            Task1();
                            break;

                        case 2:
                            Task2();
                            break;
                        case 3:
                            Task3();
                            break;

                        default:
                            Console.WriteLine("Введенный номер задания отсутствует");
                            break;
                    }
                }

                while (number != 0);
                Console.ReadKey();




            }
        }
    }
}
