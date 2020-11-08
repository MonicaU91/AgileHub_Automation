using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaS2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
            Exercise9();
            Exercise10();
            Exercise11();
            Exercise12();
            Exercise13();
            Exercise14();
            Exercise15();
            Exercise16();
            Exercise17();
            Exercise18();
            Exercise19();

        }

        public static void Exercise1()
        {
            Console.WriteLine("Insert a number:");
            string num = Console.ReadLine();
            int num2 = Int32.Parse(num);

            if (num2 == 20)
            {
                Console.WriteLine($"Numarul tau este egal cu 20");
            }

            Console.ReadLine();
        }
        public static void Exercise2()
        {
            Console.WriteLine("Insert a word:");
            string word = Console.ReadLine();
            string cuvant = "automation";
            if (word == cuvant)
            {
                Console.WriteLine($"Cuvantul pe care tu l-ai citit este: “automation” ");
            }
            Console.ReadLine();
        }
        public static void Exercise3()
        {
            bool res;
            Console.WriteLine("Insert a character:");
            char character = Convert.ToChar(Console.ReadLine());

            res = Char.IsDigit(character);
            if (res)
            {
                Console.WriteLine($"Caracterul {character} pe care l-ai introdus este cifra!");
            }

            Console.ReadLine();
        }
        public static void Exercise4()
        {
            Console.WriteLine("Insert a number:");
            string a = Console.ReadLine();
            int b = Int32.Parse(a);

            if (b < 20)
            {
                int c = b + 5;
                Console.WriteLine($"The new number is {c}");
            }

            Console.ReadLine();
        }
        public static void Exercise5()
        {
            Console.WriteLine("Insert a number:");
            string number = Console.ReadLine();
            int b = Int32.Parse(number);

            if (b > 0)
            {
                Console.WriteLine($"Numarul {b} este pozitiv");
            }
            Console.ReadLine();
        }
        public static void Exercise6()
        {
            Console.WriteLine("Insert a number:");
            string nr = Console.ReadLine();
            int d = Int32.Parse(nr);

            if (d < 20 || d > 40)
            {
                Console.WriteLine("Numarul este mai mic de 20 sau mai mare de 40!");
            }
            Console.ReadLine();
        }
        public static void Exercise7()
        {
            Console.WriteLine("Insert a number:");
            string numb = Console.ReadLine();
            int f = Int32.Parse(numb);

            if (f % 2 == 0)
            {
                Console.WriteLine($"Numarul {f} pe care l-ati introdus este par!");
            }
            Console.ReadLine();
        }
        public static void Exercise8()
        {
            Console.WriteLine("Insert a number:");
            string numar = Console.ReadLine();
            int e = Int32.Parse(numar);

            if (e == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
            else
            {
                Console.WriteLine("Numarul tau este diferit de 20!");
            }
            Console.ReadLine();
        }
        public static void Exercise9()
        {
            Console.WriteLine("Insert a word:");
            string word1 = Console.ReadLine();

            if (word1 == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este: “automation” ");
            }
            else
            {
                Console.WriteLine("Cuvantul pe care l-ai citit nu este “automation” ");
            }
            Console.ReadLine();
        }

        public static void Exercise10()
        {
            bool res;
            Console.WriteLine("Insert a character:");
            char character = Convert.ToChar(Console.ReadLine());

            res = Char.IsDigit(character);
            if (res)
            {
                Console.WriteLine($"Caracterul {character} pe care l-ai introdus este cifra!");
            }
            else
            {
                Console.WriteLine($"Caracterul {character} pe care l-ai introdus nu este cifra!");
            }

            Console.ReadLine();
        }
        public static void Exercise11()
        {
            Console.WriteLine("Insert a number:");
            string x = Console.ReadLine();
            int y = Int32.Parse(x);

            if (y < 20)
            {
                int z = y + 5;
                Console.WriteLine($"The new number is {z}");
            }
            else
            {
                int v = y - 5;
                Console.WriteLine($"The new number is {v}");
            }

            Console.ReadLine();
        }
        public static void Exercise12()
        {
            Console.WriteLine("Insert a number:");
            string abc = Console.ReadLine();
            int bcd = Int32.Parse(abc);

            if (bcd % 2 == 0)
            {
                Console.WriteLine($"Numarul {bcd} este pozitiv!");
            }
            else
            {
                Console.WriteLine($"Numarul {bcd} este negativ!");
            }
            Console.ReadLine();
        }
        public static void Exercise13()
        {
            Console.WriteLine("Insert a number:");
            string cuvant = Console.ReadLine();
            int test = Int32.Parse(cuvant);

            if (test < 20 || test > 40)
            {
                Console.WriteLine("Numarul este mai mic de 20 sau mai mare de 40!");
            }
            else
            {
                Console.WriteLine("Numarul este intre 20 si 40!");
            }
            Console.ReadLine();
        }
        public static void Exercise14()
        {
            Console.WriteLine("Insert a number:");
            string nr2 = Console.ReadLine();
            int id = Int32.Parse(nr2);

            if (id % 2 == 0)
            {
                Console.WriteLine($"Numarul {id} pe care l-ati introdus este par!");
            }
            else
            {
                Console.WriteLine($"Numarul {id} pe care l-ati introdus este impar!");
            }
            Console.ReadLine();

        }
        public static void Exercise15()
        {
            bool res;
            bool tes;
            Console.WriteLine("Insert a character:");
            char character = Convert.ToChar(Console.ReadLine());

            res = Char.IsDigit(character);
            tes = Char.IsLetter(character);
            if (tes)
            {
                Console.WriteLine($"Caracterul {character} este litera!");
            }
            else if (res)
            {
                Console.WriteLine($"Caracterul {character} este o cifra !");
            }
            else
            {
                Console.WriteLine($"Caracterul {character} nu este nici cifra nici litera !");
            }

            Console.ReadLine();
        }

        public static void Exercise16()
        {
            
            Console.WriteLine("Insert an hour: ");
            string hour = Console.ReadLine();
            string hour1 = "12:00";
            string hour2 = "17:00";
            var h = Convert.ToDateTime(hour);
            var g = Convert.ToDateTime(hour1);
            var j = Convert.ToDateTime(hour2);
            
            
            if (h < g)
            {
                Console.WriteLine("Buna dimineata!");
            }
            else if (h > g && h < j)
            {
                Console.WriteLine("Buna ziua");
            }
            else
            {
                Console.WriteLine("Buna seara");
            }
            Console.ReadLine();
        }
        
        public static void Exercise17()
        {
            Console.WriteLine("Please insert yout height in cm");
            string cm = Console.ReadLine();
            int height = Int32.Parse(cm);

            if (height < 150)
            {
                Console.WriteLine("Aceasta persoana este miniona");
            }
            else if (height > 150 && height < 165)
            {
                Console.WriteLine("Aceasta persoana este mica de statura");
            }
            else if (height > 165 && height < 195)
            {
                Console.WriteLine("Aceasta persoana este inalta");
            }
            else
            {
                Console.WriteLine("Aceasta persoana este foarte inalta");
            }
            Console.ReadLine();
        }
        public static void Exercise18()
        {
            int a, b, c;
            Console.WriteLine("Enter first number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number :");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"{a} is the largest number");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} is the largest number");
            }
            else
            {
                Console.WriteLine($"{c} is the largest number");
            }
            Console.ReadLine();
        }
        public static void Exercise19()
        {
            int m, n;
            char l;
            Console.WriteLine("Enter first number :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operator (+,-,*,/) :");
            l = Convert.ToChar(Console.ReadLine());
            if (l == '+')
            {
                int sum = m + n;
                Console.WriteLine($"{m} {l} {n} = {sum}");
            }
            else if (l == '-')
            {
                int dif = m - n;
                Console.WriteLine($"{m} {l} {n} = {dif}");
            }
            else if (l == '*')
            {
                int inmultire = m * n;
                Console.WriteLine($"{m} {l} {n} = {inmultire}");
            }
            else if (l == '/')
            {
                int impartire = m / n;
                Console.WriteLine($"{m} {l} {n} = {impartire}");
            }
            Console.ReadLine();
        }

    }
}
