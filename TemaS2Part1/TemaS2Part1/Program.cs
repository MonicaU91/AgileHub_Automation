
using System;

namespace TemaS2Part1
{
    class Program
    {
        public static void Main()
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
            Exercise13();
            Exercise15();
            Exercise16();
            Exercise17();
            Exercise18();
            Exercise19();
            Exercise20();
            Exercise21();
            Exercise22();
            Exercise23();
            Exercise24();
            Exercise25();
        }
        //1.Scrieti un program care sa afiseze primele 10 numere naturale.
        public static void Exercise1()
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //OR

            int a = 0;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadLine();
        }
        //2.Scrieti un program care sa afiseze suma primelor 10 numere naturale
        public static void Exercise2()
        {
            //ex.16
        }
        //3.Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi.
        public static void Exercise3()
        {
            Console.WriteLine("Enter a number : ");
            int i;
            int n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        //4. Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi.
        public static void Exercise4()
        {
            Console.WriteLine("Enter a number: ");
            int i;
            int c = int.Parse(Console.ReadLine());
            for (i = 3; i < c; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        //5.Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi
        public static void Exercise5()
        {
            // ex12
        }

        //6.Afisati cubul primelor 5 numere naturale.
        public static void Exercise6()//GRESIT
        {
            int i = 0 ;
            i++;
            if (i <= 4)
            {
                 Console.WriteLine(i * i * i );
            }

            Console.ReadLine();
        }

        //7.Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.

        public static void Exercise7()
        {
            Console.WriteLine("Enter a number : ");
            int z = int.Parse(Console.ReadLine());
            int d = 0;
            do
            {
                if (d % 2 == 0)
                {
                    Console.WriteLine(d);
                }
                d++;
            }
            while (d < z);
            Console.ReadLine();
        }
        //8.Scrieti un program care sa afiseze primele 10 numere naturale.( do while)
        public static void Exercise8()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }

            while (i < 10);
            Console.ReadLine();
        }

        //9.Scrieti un program care sa afiseze suma primelor 10 numere naturale. ( do while)--GRESIT
        public static void Exercise9()
        {
            int i = 0;
            int sum = 0;
            i++;
            sum = sum + i;
            do
            {
                
                Console.WriteLine(sum);
                
            } while (i <= 10);

            Console.ReadLine();
        }
    //    int sum = 0;
    //    int i;
    //        for (i = 0; i <= 10; i++)
    //        {
    //            sum = sum + i;
    //        }
    //Console.WriteLine(sum);

        //10.Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. .( do while)
        public static void Exercise10()
        {
            int a = 0;
            Console.WriteLine("Enter a number: ");
            int i = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(a);
                a++;

            } while (a < i);
            Console.ReadLine();
        }

        //11.Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. .( do while)
        public static void Exercise11()
        {
            int f = 3;
            Console.WriteLine("Enter a number: ");
            int k = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(k);
                k--;

            } while (f < k);
            Console.ReadLine();
        }

        //12.Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. .( do while)--GRESIT
        public static void Exercise12()
        {
            int z = 0;
            int sum = 0;
            Console.WriteLine("Enter a number : ");
            int w = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(sum);
                w--;
                sum = sum + w;

            } while (z < w);
            Console.ReadLine();
        }
        //13.	Afisati cubul primelor 5 numere naturale. .( do while)
        public static void Exercise13()
        {
            int i = 0;
            int j = 4;
            do
            {
                Console.WriteLine(Math.Pow(i, 3));
                i++;
            } while (i <= j);
            Console.ReadLine();
        }

        //14.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. .( do while)

        //15.Scrieti un program care sa afiseze primele 10 numere naturale. (for)

        public static void Exercise15()
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        //16.Scrieti un program care sa afiseze suma primelor 10 numere naturale. (for)
        public static void Exercise16()
        {
            int sum = 0;
            int i;
            for (i = 0; i < 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        //17.Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. (for)

        public static void Exercise17()
        {
            int i;
            Console.WriteLine("Enter a number: ");
            int g = int.Parse(Console.ReadLine());
            for (i = 0; i < g; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        //18.Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. (for)
        public static void Exercise18()
        {
            int m;
            Console.WriteLine("Enter a number: ");
            int l = int.Parse(Console.ReadLine());
            for (m = 3; m < l; m++)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
        //19.Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. (for)
        public static void Exercise19()
        {
            Console.WriteLine("Enter a number : ");
            int y = int.Parse(Console.ReadLine());
            int i;
            int sum = 0;
            for (i = 0; i < y; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        //20.	Afisati cubul primelor 5 numere naturale. (for)
        public static void Exercise20()
        {
            int i;
            for (i = 0; i <= 4; i++)
            {

                Console.WriteLine(Math.Pow(i, 3));
            }
            Console.ReadLine();
        }

        //21.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. (for)

        public static void Exercise21()
        {
            Console.WriteLine("Enter a number : ");
            int a = int.Parse(Console.ReadLine());
            int b;

            for (b = 1; b < a; b++)
            {
                if (b % 2 == 0)
                {
                    Console.WriteLine(b);
                }
            }
            Console.ReadLine();
        }
        //22.Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.

        public static void Exercise22()
        {
            string[] MyArray = new string[] { "sun", "moon", "clouds" };
            Console.WriteLine(MyArray[1]);
            Console.ReadLine();
        }

        //23.Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”
        public static void Exercise23()
        {
            string[] fruits = new string[] { "lemons", "watermelon", "cherry" };
            Console.WriteLine(fruits[2]);
            Console.ReadLine();
        }

        //24.	Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.--GRESIT

        public static void Exercise24()
        {
            string[] family = new string[] { "mom", "dad", "child" };
            Array.Reverse(family);
            Console.WriteLine(family);
            Console.ReadLine();
        }

        //25.Afisati array-ul sortat: “mom”, “dad”, “child”.
        public static void Exercise25()
        {
            string[] family = new string[] { "mom", "dad", "child" };
            // Array.Sort(family);
            Console.WriteLine(family[2] + "\n" + family[1] + "\n" + family[0]);
            Console.ReadLine();
        }

        //26.Cititi de la tastatura elementele unui array de marime 5. (string)
        public static void Exercise26()
        {
            string[] myArray = new string[5];
            myArray[0] = "red";
            myArray[1] = "blue";
            myArray[2] = "purple";
            myArray[3] = "orange";
            myArray[4] = "black";
            Console.WriteLine("Enter 5 colours: ");
        }

        //27.	Cititi de la tastatura elementele unui array de marime 5.(int)

    }
}
