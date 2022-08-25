using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Day1
{
    internal class Latihan_Day1
    {
        public static void SumAllNumberNo1()
        {
            int sum = 0;
            Console.Write("Enter number integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                sum += (number % 10);
                number /= 10;
            }
            Console.WriteLine($"Total Sum : {sum}");
        }

        public static void SumDigitNo2()
        {
            int hasilDigit = 0;
            Console.Write("Enter number integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine($"Total Digit : {count}");
        }

        public static void ReverseNo3()
        {
            int hasilBagi = 0;
            Console.Write("Enter number integer : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                hasilBagi = number % 10;
                number /= 10;
                Console.Write(hasilBagi + " ");
            }
        }

        public static void NilaiMaxKeduaNo4()
        {
            int max = 0;
            Console.Write("Enter max number loop : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int terbesar = 0;

            for (int i = 1; i < number; i++)
            {
                terbesar++;
            }
            Console.WriteLine($"Second Greatest : {terbesar}");
        }

        public static void GuessNumberNo5()
        {
            Console.WriteLine("Guess Magic Number Between 0 - 20 : ");

            Random rand = new Random();
            int number = rand.Next(0, 20);

            int guess = -1;

            while (guess != number)
            {
                Console.WriteLine("Enter Your Guess ?");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                //cek kondisi
                if (guess == number)
                {
                    Console.WriteLine($"You're Right. number :{guess}");
                    Console.WriteLine("Tebak Lagi?");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        GuessNumberNo5();
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You're Quit");
                        break;
                    }
                }
                else if (guess > number)
                {
                    Console.WriteLine("You're Guess is too High");
                }
                else
                {
                    Console.WriteLine("You're Guess is too Low");
                }
            }
        }
        public static void AngkaTerbesarNo6()
        {
            int max = int.MinValue;
            int number = 0;
            for (int i = 1; i > number; i++)
            {
                Console.Write("Masukkan Angka [0 for exit] : ");
                int angka = Convert.ToInt32(Console.ReadLine());
                if (angka > max)
                {
                    max = angka;
                }
                else if (number == 0)
                {
                    Console.WriteLine($"Angka Terbesar : {max}");
                    break;
                }
            }
        }
        public static void AngkaPembagiNo7()
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void PrimeNumberNo8()
        {
            int bilangan;
            Console.Write("Enter Limit Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bilangan = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        bilangan += 1;
                    }
                }
                if (bilangan == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void PalindromeNo9()
        {
            Console.Write("Enter String : ");
            string kata = Console.ReadLine();
            string lower = kata.ToLower();
            bool status = false;
            for (int i = 0; i < kata.Length; i++)
            {
                if (lower[i] == lower[lower.Length - i - 1])
                {
                    Console.WriteLine(lower[i] + " : " + lower[lower.Length - i - 1]);
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            if (status == true)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
        //coba pake char
        public static void VocalConsonantNo10()
        {
            Console.Write("Enter String : ");
            string kata = Console.ReadLine();
            string lower = kata.ToLower();

            string text = "";
            int sumVowel = 0;
            int sumConsonant = 0;

            for (int i = 0; i < kata.Length; i++)
            {
                text = lower[i].ToString();
                if (text == "a" || text == "i" ||
                    text == "u" || text == "e" ||
                    text == "o")
                {
                    sumVowel++;
                }
                else if (text != " ")
                {
                    sumConsonant++;
                }
            }
            Console.WriteLine($"Vowel : {sumVowel}");
            Console.WriteLine($"Consonant : {sumConsonant}");
        }
        public static void JumlahKataNo11()
        {
            Console.Write("Enter String : ");
            string kata = Console.ReadLine();
            string text = "";
            int sum = 0;
            for (int i = 0; i < kata.Length; i++)
            {
                text = kata[i].ToString();
                if (text == " " || i == kata.Length - 1)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Total Words : {sum}");
        }

        public static void ReplaceMiddleCharacterNo12()
        {
            Console.Write("Enter String : ");
            string kata = Console.ReadLine();
            string text = "";
            string ubah = "";

            for (int i = 0; i < kata.Length; i++)
            {
                text = kata[i].ToString();
                if (i == 0)
                {
                    ubah += text[i];
                }
                else if (i == kata.Length - 1)
                {
                    ubah += text[text.Length - 1];
                }
                else if (text == " ")
                {
                    ubah += " ";
                }
                else if (text != " ")
                {
                    ubah += "*";
                }
            }
            Console.WriteLine(ubah);
        }

        public static void HitungHariNo13()
        {
            DateTime now = DateTime.Now;
            DayOfWeek sekarang = now.DayOfWeek;
            DayOfWeek sabtu = DayOfWeek.Saturday;
            int daysRemaining = sabtu - sekarang;
            Console.WriteLine($"Hari Sabtu : {now.AddDays(daysRemaining).ToShortDateString()} \n{daysRemaining} hari lagi!");
        }

        public static void MenemukkanPolaNo14()
        {
            Console.Write("Masukkan text : ");
            string input = Console.ReadLine();
            Console.Write("Temukan Pola : ");
            string pola = Console.ReadLine();

            int a = 0;
            int jumlah = 0;

            while ((a = input.IndexOf(pola, a)) != -1)
            {
                a += pola.Length;
                jumlah++;
            }
            Console.WriteLine($"{pola} muncul sebanyak : {jumlah}");
        }

        public static void AngkaKeduaTerbesarNo15()
        {
            int max = int.MinValue;
            int max2 = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter {i + 1}. Masukkan Angka : ");
                int angka = Convert.ToInt32(Console.ReadLine());
                if (angka > max)
                {
                    max2 = max;
                    max = angka;
                }   
            }
            Console.WriteLine($"Angka Kedua Terbesar : {max2}");
        }
    }
}
