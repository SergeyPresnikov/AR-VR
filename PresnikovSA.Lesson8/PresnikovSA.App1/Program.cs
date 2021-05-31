using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PresnikovSA.App1
{
    class Program
    {/// <summary>
     /// С помощью рефлексии выведите все свойства структуры DateTime
     /// </summary>
     
     //Пресников С.А.
        static void Main()
        {
            Type type = typeof(DateTime);
            foreach (var PropertyInfo in type.GetProperties())
            Console.WriteLine(PropertyInfo.Name);

            Console.ReadKey();

        }
    }
}
