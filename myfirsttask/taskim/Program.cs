using System;

namespace taskim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin");
            Console.WriteLine("  ");
            string name = Console.ReadLine();
            Console.WriteLine("Xos geldiniz" +" "+ name);
            Console.ReadLine();
            bool student = true;
            Console.WriteLine("Telebesiniz?");
            string answer = Console.ReadLine();
            if (answer=="he")
            {
                Console.WriteLine("Hansi unide oxuyursunuz?Xahis edirik daxil edin");
                string university = Console.ReadLine();
                Console.WriteLine("Ixtisasiniz nedir?");
                string ixtisas = Console.ReadLine();
                Console.WriteLine("1-den 100-e qeder tek ededlerin cemini hesabla");
                Sum();
                Console.WriteLine("Tesekkur edirik" + " " + name + "Sen" + university+ "-de oxuyursan" + ixtisas + " " + "tehsili alirsan ve 1-den 100-e qeder tek ededlerin ceminin");Sum();
                Console.Write("oldugunu bilirsen");

            }
            else
            {
                Console.WriteLine("Isleyirsiniz?");
                string secondanswer = Console.ReadLine();
                if (secondanswer=="he")
                {
                    Console.WriteLine("Vezifeniz nedir?");
                    string job = Console.ReadLine();
                    Console.WriteLine("1 den 101 e qeer tek ededlerin cemini hesabla");
                    Sum2();
                    Console.WriteLine("Tesekkur edirik" + name + "Sen " + job + "vezifesinde isleyirsen ve 1-den 101-e qeder tek ededlerin ceminin ");Sum2();
                    Console.WriteLine("oldugunu bilirsen");
                }
                else
                {
                    Console.WriteLine("Boyuk ehtimalla sen sagirdsen ve buna baxmayaraq 1-den 200-e qeder olan 3-e bolunen cut ededlerin ceminin ");three();
                    Console.WriteLine("oldugunu bilirsen");
                }
            }
        }

        static void Sum()
        {
            int s = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    s += i;

                }
            }
            Console.WriteLine(s);
        }

        static void Sum2 ()
        {
            int s = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 != 0)
                {
                    s += i;

                }
            }
            Console.WriteLine(s);
        }

        static void three()
        {
            int s = 0;
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        s += i;
                    }

                }
            }
            Console.WriteLine(s);
        }

    }
}
