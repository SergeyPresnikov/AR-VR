using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresnikovSA.App1
{
    class Program
    {
        static void Task1()
        {
            //Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Задание номер 1 : Метод, возвращающий минимальное из трёх чисел");

            int a, b, c, min;
            Console.WriteLine("Введите целые числа");
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else if (c < a && c < b)
            {
                min = c;
            }
            else min = b;

            Console.WriteLine("Наименьшее число: {0}", min);
            Console.ReadLine();
        }

        static void Task2()
        {
            //Написать метод подсчета количества цифр числа.
            Console.WriteLine("Задание номер 2 : Метод подсчета количества цифр числа ");

            Console.Write("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine($"Сумма цифр числа = {count}");

            Console.ReadLine();
        }

        static void Task3()
        {
            //С клавиатуры вводятся числа, пока не будет введен 0.
            //Подсчитать сумму всех нечетных положительных чисел.
            Console.WriteLine("Задание номер 3: С клавиатуры вводятся числа, пока не будет введен 0.");
            Console.WriteLine("Подсчитать сумму всех нечетных положительных чисел");
            int a = 0;
            int b = 0;
            Console.WriteLine("Введите число:  ");

            do
            {
                b = int.Parse(Console.ReadLine());
                if (b > 0 && b % 2 == 1)
                    a += b;
            }
            while (b != 0);
            Console.WriteLine("Сумма нечетных чисел равна: " + a);
            Console.ReadLine();
        }

        static void Task4()
        {
            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля
            //тремя попытками.
            Console.WriteLine("Задание номер 4: Метод проверки логина и пароля. ");

            string log = "root";
            string pasw = "GeekBrains";

            int count = 0;
            do
            {
                Console.Write("Введите Login:");
                string CLog = Console.ReadLine();
                Console.Write("Введите Password:");
                string CPasw = Console.ReadLine();
                if (log == CLog && pasw == CPasw)
                {
                    Console.WriteLine("Добро пожаловать!!!");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Введен не верный логин или пароль");
                Console.ReadLine();
                ++count;
            }
            while (count < 3);
        }

        static void Task5()
        {
            //Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
            //и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Задание номер 5:Программа запроса массы и роста человека и вычисление его ИМТ. ");
            double m;
            double h;
            double I;


            Console.Write("Масса тела (кг): ");
            string bodymass;
            bodymass = Console.ReadLine();

            Console.Write("Рост (м): ");
            string height;
            height = Console.ReadLine();

            m = Convert.ToDouble(bodymass);
            h = Convert.ToDouble(height);
            I = m / (h * h);
            Console.WriteLine($"Индекс массы тела= {I:F2}");



            if (I < 16.49)
            {
                Console.WriteLine("У Вас выраженный дефицит массы тела");
            }

            else if (I >= 16.5 && I <= 18.49)
            {
                Console.WriteLine("У Вас дефицит массы тела");
            }

            else if (I >= 18.5 && I <= 24.99)
            {
                Console.WriteLine("У Вас нормальная масса тела");
            }

            else if (I >= 25.5 && I <= 29.99)
            {
                Console.WriteLine("У Вас избыточная масса тела (предожирение)");
            }

            else if (I >= 30 && I <= 34.99)
            {
                Console.WriteLine("У Вас впервая степень ожирения");
            }

            else if (I >= 35 && I <= 39.99)
            {
                Console.WriteLine("У Вас вторая степень ожирения");
            }

            else
            {
                Console.WriteLine("У Вас третья степень ожирения");
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Введите номер задания (1,2,3,4,5):  ");
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

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
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
