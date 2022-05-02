using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BleedGoat.Utilities
{
    public static class MooncakeUtils
    {
        public static int CountWords(this string s)
        {
            var result = -1;

            var words = s.Split(' ', '.', ',');

            result = words.Where(w => w.Length > 0).Count();     //'where' - filter


            return result;
        }
    }
}
