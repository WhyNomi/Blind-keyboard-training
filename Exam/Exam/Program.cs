using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Timers;

namespace ConsoleTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Blind-keyboard training";

            Console.WriteLine("Оберіть рівень гри:\nlvl 1 - Crock\nlvl 2 - Mafia Boss\nlvl 3 - Papa\nlvl 4 - Mega Crock\nНатисніть 1, 2, 3 або 4 для вибору рівня..");
            char buff;
            int size = 0;

            buff = Console.ReadKey(true).KeyChar; ;
            if (buff == '1') size = 25;
            else if (buff == '2') size = 45;
            else if (buff == '3') size = 65;
            else if (buff == '4') size = 90;

            char[] arr1 = new char[size];

            //----------------RAND----------------------//
            Random rnd = new Random();
            char[] arr = new char[size];

            for (int i = 0; i < size; i++)
            {
                if (i % 5 == 0 && i > 0)
                {
                    arr[i] = ' ';
                    i++;
                }
                arr[i] = Convert.ToChar(rnd.Next(97, 122));
            }
            //----------------RAND----------------------//

            //-------------Convert-------------------//
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            //-------------Convert-------------------//

            //---------------Check------------------//
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                buff = Console.ReadKey(true).KeyChar;
                Console.Write(buff);
                if (buff != arr[i])
                {
                    Console.Write('\a');
                    counter++;

                }
            }
            //---------------Check------------------//

            //---------------Menu------------------//
            Console.WriteLine("\n");
            Console.WriteLine("\n\t**************************");
            Console.WriteLine($"\t** У вас: {size - counter} збігів **");
            Console.WriteLine($"\t** У вас: {counter} помилок       **");
            Console.WriteLine("\t**************************");
            //---------------Menu------------------//
        }

    }

}

