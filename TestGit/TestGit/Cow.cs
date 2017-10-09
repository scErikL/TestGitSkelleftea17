using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Cow
    {
        string s = "Cow";

        public static Cow operator * (Cow a, float b)
        {
            Cow c = new Cow();

            if (b == 0)
	            {
            c.s = "They all died =(";
	            }

            for (int i = 0; i < b - 1; i++)
            {
                c.s += " Cow";
            }

            return c;
        }

        public override string ToString()
        {
            return s;
        }
    }
}
