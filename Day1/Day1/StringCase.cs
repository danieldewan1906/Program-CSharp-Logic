using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class StringCase
    {
        public static void StringsCase()
        {
            //substring
            string word = "Code Academy Bootcamp";
            string cutWord = word.Substring(5, 7);
            Console.WriteLine(cutWord);
            Console.WriteLine($"'{word}' panjang kata : {word.Length}");
            Console.WriteLine($"{word.Replace("Code", "Daniel")}");

            String cutAcademy = word.Substring(word.IndexOf("Academy"), 7);
            Console.WriteLine($"cutAcademy : {cutAcademy}");
        }
        //word = "ABC", output = "CBA"
        public static string ReverseString(string word)
        {
            string reverse = "";
            char[] chars = word.ToCharArray();
            reverse += chars.ElementAt(2);
            reverse += chars.ElementAt(1);
            reverse += chars.ElementAt(0);
            return reverse;
        }

        public static StringBuilder ReverseStringBuilder(string word)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = word.ToCharArray();
            sb.Append(chars.ElementAt(2));
            sb.Append(chars.ElementAt(1));
            sb.Append(chars.ElementAt(0));
            return sb;
        }


    }
}
