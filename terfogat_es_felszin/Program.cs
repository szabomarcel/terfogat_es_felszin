using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terfogat_es_felszin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Testek> testek = new List<Testek>();
            testek.Add(new Teglatest(1, 2, 3));
            testek.Add(new Kocka(3));
            testek.Add(new Henger(3, 5));
            foreach (var item in testek)
            {
                if (item.GetType().Equals(typeof(Teglatest)))
                {
                    Teglatest kor = (Teglatest)item; // -- Csak így juthatunk az egyedi adathoz, a sugérhoz
                    //Console.WriteLine($"\nAz 1. elem {item.GetType()} - {item}");
                    Console.WriteLine($"A téglatest Felszine: {kor.Felszin()} - Terfogata: {kor.Terfogat()}");
                }
                else if (item.GetType().Equals(typeof(Kocka)))
                {
                    Kocka negyzet = (Kocka)item;
                    Console.WriteLine($"\nA kocka Felszine: {negyzet.Felszin()} - Terfogata: {negyzet.Terfogat()}");
                }
                else if (item.GetType().Equals(typeof(Henger)))
                {
                    Henger teglalap = (Henger)item;
                    Console.WriteLine($"\nA henger Felszine: {teglalap.Felszin()} - Terfogata: {teglalap.Terfogat()}");
                }
            }
            Console.ReadLine();
        }
    }
}
