using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Services
{
    public static class Extensions
    {
        public static string WordTrimEnd(this string str, string word)
        {
            var wordArray = word.ToArray().Reverse();
            foreach(var item in wordArray)
            {
                str = str.TrimEnd(item);
            }
            return str;
        }
    }
}
