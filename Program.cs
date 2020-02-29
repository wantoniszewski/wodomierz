using System;
using System.Collections.Generic;

namespace delegaty
{
    class Program
    {
        public delegate void TypDelegata1(string s);

        static void Metoda1 (string k)
        {
            Console.WriteLine($"wywołanie \"Metoda1\", z parametrem: {k}");
        }

        void Metoda2(string k)
        {
            Console.WriteLine($"wywołanie \"Metoda2\", z parametrem: {k}");
        }

        static string Funkcja1(int a, int b)
        {
            return $"{a}<<<<>>>>{b}";
        }
        static string Funkcja2(int a, string b)
        {
            return $"{a}-----{b}";
        }
        static void Main(string[] args)
        {

            List<Func<int, string, string>> lista = new List<Func<int, string, string>>();
            lista.Add(Funkcja2);
            lista.Add((a, b) => { return $"{a}++++{b}"; });

            foreach (var item in lista)
            {
                Console.WriteLine(item(1,"jeden"));
            }

            Action<string> akcja = Metoda1;
            akcja += q => { Console.WriteLine($"wywyłanie lamby z parametrem {q}"); };

            Func<int, int, string> funkcja = Funkcja1;

            funkcja += (a, b) => {
                Console.WriteLine("wykonanie \"lambda do funkcji\"");
                return $">>>>>{a}----{b}<<<<<";
            };

            Console.WriteLine($"wynik delegata funjkcja{funkcja(1,2)}");

            Program p = new Program();
            //TypDelegata1 zmienna1 = Program.Metoda1;
            TypDelegata1 zmienna1 = new TypDelegata1(Program.Metoda1);
            zmienna1 += p.Metoda2;
            zmienna1("test");

            List<TypDelegata1> lista1 = new list<TypDelegata1>();
            lista1.Add(Metoda1);
            lista1.Add(p.Metoda2);
            lista1.Add(w =>
            {
                Console.WriteLine($"wywyłanie \"Lambda1\", z parametrem: {w}");
            }
            );
            Console.WriteLine("-----====----");

            foreach (var item in lista1)
            {
                item("test");
            }

        }
    }
}
