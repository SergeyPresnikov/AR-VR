﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresnikovSA.App1
{
    class Program
    {/// <summary>
     /// Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
     /// Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, 
     /// в которых только одно число делится на 3. 
     /// В данной задаче под парой подразумевается два подряд идущих элемента массива.
     /// </summary>
        public class MyArray
        {
            private int[] am;
            
           
            public MyArray (int n, int min, int max)
            {
                am = new int[n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                    am[i] = random.Next(min, max);
            }
           
            public int Dividedby3()
            {
                int count = 0;
                for (int i = 0; i < am.Length - 1; i++)
                {
                    if (am[i] % 3 == 0 | am[i+1] % 3 == 0)
                        count++;
                    Console.WriteLine($"Пара элементов массива : {am[i]} и {am[i+1]}");
                }

                Console.WriteLine($"Количество пар: { count} ");
                return count;
            }
         
            public override string ToString()
            {
                string stringarray = "   ";
                foreach (int x in am)
                    stringarray = stringarray + x + "  ";
                return stringarray;
            }
          
            static void Main(string[] args)
            {
              
                MyArray myArray = new MyArray(20, -10000, 10000);
                Console.WriteLine(myArray.ToString());
                myArray.Dividedby3();
                Console.ReadLine();
            }

        }





    }
}
