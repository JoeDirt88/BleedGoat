using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BleedGoat.Utilities
{
    public static class JoeUtils
    {
        public static string MakeHearts(this string s, char c) //method
        {
            return s.Replace(c.ToString(), "♥");  //statement
        }


    }

    public static class CUtils
    {
        public static void Continue(bool clear = false)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            if (clear)
                Console.Clear();
        }
    }
}
