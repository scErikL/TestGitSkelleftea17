﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // Mer kommentarer!

            //  ( ͡° ͜ʖ ͡°)
            Console.WriteLine("#LennyFace");
            Console.WriteLine("wow, vilken cool kodrad det här är!"); // Magnus
            Console.WriteLine("Ett random nummer: {0}", getNumberAsString(new Random().Next())); // Jimmy

            // (ง꘠▾꘠)ง
            Console.WriteLine("helt galet hur cool den här koden är!"); // ErikÖ

            Console.WriteLine("Testar GítHub");
            Console.ReadKey();

            Console.WriteLine("Erik Lövbom");
        }

        public static string getNumberAsString(int nr)
        {
            return nr.ToString();
        }

        
    }
}
