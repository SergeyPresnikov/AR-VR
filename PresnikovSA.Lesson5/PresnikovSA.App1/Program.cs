using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PresnikovSA.App1
{
    static class Message
    {
        static public string text;


        static Message()
        {
            text = (@"Я таял, но среди неверной темноты, другие милые мне виделись черты." +
                     "\nИ весь я полон был таинственной печали, и имя чуждое уста мои шептали.");
        }


        private static char[] separators = { ',', '.', ' ', '!', ';', ':', '?' };


        static public void PrintWords(int len)
        {
            string[] words = text.Split(new char[] { ',', '.', ' ', '!', ';', ':', '?' });
            foreach (string word in words)
            {
                if (word == " ")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + "  ");
            }
        }

        static public void DeleteWords(char ch)
        {
            string[] words = text.Split(new Char[] { ',', '.', ' ', '!', ';', ':', '?' });

            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + "  ");
                    text.Replace(word, "  ");
                }

            }

        }

        static public string MaxLenghtWord()
        {
            string[] words = text.Split(new char[] { ',', '.', ' ', '!', ';', ':', '?' });
            string maxWord = words[0];
            int max = words[0].Length;
            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }

            return maxWord;
        }

        static public StringBuilder LongWordString()
        {
            string[] words = text.Split(new char[] { ',', '.', ' ', '!', ';', ':', '?' });
            StringBuilder result = new StringBuilder();
            int max = Message.MaxLenghtWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + "  ");
                }
            }

            return result;
        }


    }
    class Program
    {
        private static bool IsLatinLetter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }
        static bool Login (string login)
        {
            int length = login.Length;
            if( length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || IsLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }

        static bool LoginReg(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }


        static void Task1()
        {
            Console.WriteLine("Программа проверки корректности логина без использования регулярных выражений.");

            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            if (Login(login))
            {
                Console.WriteLine("Логин корректен!");
            }
            else
            {
                Console.WriteLine(@"Неверный ввод логина.
                        Должны быть соблюдены следующие условия:
                        1) Длина строки от 2 до 10 символов;
                        2) Буквы только латинского алфавита или цифры;
                        3) Цифра не может быть первой.");
            }
            Console.ReadKey();
        }

        static void Task2()
        {
            Console.WriteLine("Программа проверки корректности логина с использованием регулярных выражений.");

            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            if (LoginReg(login))
            {
                Console.WriteLine("Логин корректен!");
            }
            else
            {
                Console.WriteLine(@"Неверный ввод логина.
                 Должны быть соблюдены следующие условия:
                 1) Длина строки от 2 до 10 символов;
                 2) Буквы латинского алфавита или цифры;
                 3) Цифра не может быть первой.");
            }
            Console.ReadKey();
        }

        static void Task3()
        {
            Console.WriteLine($"\nДан текст:{Message.text} ");
            Console.WriteLine("\nВыведем все слова, которые содержат не более 4 букв:");
            Message.PrintWords(4);
            Console.WriteLine();
            Console.WriteLine("\nУдалим все слова заканчивающиеся на букву-'е':");
            Message.DeleteWords('е');
            Console.WriteLine();
            Console.WriteLine($"\nСамое длинное слово в тексте : { Message.MaxLenghtWord()}");
            Console.WriteLine($"\nСтрока из самых длинных слов текста : { Message.LongWordString()}");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            int number;
            do
            {
                Console.WriteLine("Введите номер задания - 1 (1a),2 (1б), 3:  ");
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
