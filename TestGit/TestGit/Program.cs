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



            //  ( ͡° ͜ʖ ͡°)
            Console.WriteLine("wow, vilken cool kodrad det här är!"); // Magnus


            Console.WriteLine("Testar GítHub");
            
            Console.ReadKey();

            Console.WriteLine("Erik Lövbom");


            Cow cows = new Cow();

            cows *= 4;

            Console.WriteLine(cows.ToString());

            Console.ReadKey();
            
        }

        public static string getNumberAsString(int nr)
        {
            return nr.ToString();
        }

        
    }
}
