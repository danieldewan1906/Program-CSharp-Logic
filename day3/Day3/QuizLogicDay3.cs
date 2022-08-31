using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class QuizLogicDay3
    {
        public static void ShowList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }

        public static void ShowDictionary(Dictionary<int, long> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item.Key} {item.Value}");
            }
        }
        public static List<T> Nomor1<T>(ref List<T> list1, ref List<T> list2)
        {
            var myList = list1;
            var yourList = list2;
            var result = new HashSet<T>(myList);
            result.IntersectWith(yourList);
            Console.WriteLine("Intersect : ");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            var result2 = new HashSet<T>(myList);
            result2.UnionWith(yourList);
            Console.WriteLine("Union : ");
            foreach (var item in result2)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            var result3 = new HashSet<T>(myList);
            result3.ExceptWith(yourList);
            Console.WriteLine("Except : ");
            foreach (var item in result3)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            var result4 = new HashSet<T>(myList);
            result4.SymmetricExceptWith(yourList);
            Console.WriteLine("Symetric Except : ");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            return myList;
        }
        public static List<T> Reverse<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }

            Console.WriteLine("Element");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            myList.Reverse();
            Console.WriteLine("Reverse : ");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }
            return myList;
        }
        public static List<T> RemoveDuplicate<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }

            Console.WriteLine("Element");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            myList.Sort();
            var temp = myList.Distinct().ToList();
            Console.WriteLine("Distinct Element : ");
            foreach (var item in temp)
            {
                Console.Write($"{item} ");
            }
            return myList;
        }

        public static List<T> ListSameDifferent<T>(ref List<T> list, ref List<T> list2)
        {
            var myList = list;
            var yourList = list2;
            var result = new HashSet<T>(myList);
            result.IntersectWith(yourList);
            foreach (var item in result.ToList())
            {
                Console.Write($"{item} ");
            }

            var result2 = new HashSet<T>(myList);
            result2.SymmetricExceptWith(yourList);
            Console.WriteLine();
            foreach (var item in result2.ToList())
            {
                Console.Write($"{item} ");
            }
            return myList;
        }
        public static Dictionary<int, long> ValueCount<T>(ref List<T> list)
        {
            var dict = new Dictionary<int, long>();
            var myList = list;
            long count = 0;
            myList.Sort();
            foreach (var item in myList)
            {
                count = 0;
                foreach (var item2 in myList)
                {
                    if (item.Equals(item2))
                    {
                        count++;
                    }
                }
                dict.Add(Convert.ToInt16(item), count);
                Console.WriteLine(dict);
            }

            
            return dict;
        }

        /*       public static List<T> ListAddition<T>(ref List<T> list1, ref List<T> list2)
               {
                   var myList = list1;
                   var yourList = list2;
                   var tempList = new List<T>();
                   for (int i = 0; i < myList.Count; i++)
                   {
                       tempList.Where(x => x++);
                   }
                   return tempList;
               }*/

    }
}
