using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace balkezesek
{
    class Balkezesek
    {
        public string Nev { get; set; }
        public int Elso { get; set; }
        public int Utolso { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Balkezesek(string nev, int elso, int utolso, int suly, int magassag)
        {
            Nev = nev;
            Elso = elso;
            Utolso = utolso;
            Suly = suly;
            Magassag = magassag;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //beolvasás
            string[] input = File.ReadAllLines("balkezesek.csv", System.Text.Encoding.UTF8);
            List<Balkezesek> balkezesek = new List<Balkezesek>();
            for (int i = 1; i < input.Length; i++)
            {
                string[] split = input[i].Split(';');

                string nev = split[0];
                int elso = int.Parse(split[1].Split('-')[0]);
                int utolso = int.Parse(split[2].Split('-')[0]);
                int suly = int.Parse(split[3]);
                int magassag = int.Parse(split[4]);

                balkezesek.Add(new Balkezesek(nev, elso, utolso, suly, magassag));
            }

            //3.feladat
            Console.WriteLine($"3.feladat: {balkezesek.Count}");

            //4.feladat
            Console.WriteLine("\n4.feladat");
            List<Balkezesek> in99 = balkezesek.FindAll(x => x.Utolso == 1999);
            foreach (Balkezesek item in in99)
            {
                Console.WriteLine($"{item.Nev}, {item.Magassag * 2.54}cm");
            }

            //5.feladat
            Console.WriteLine("\n5.feladat");
            Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
            int evszam = int.Parse(Console.ReadLine());
            while (!(1990 <= evszam && evszam <= 1999))
            {
                Console.Write("Hibás adat,kérek egy 1990 és 1999 közötti évszámot!: ");
                evszam = int.Parse(Console.ReadLine());
            }

            //6.feladat
            List<Balkezesek> playersInEvszam = balkezesek.FindAll(x => x.Elso <= evszam && x.Utolso >= evszam);
            double atlagSuly = 0;
            foreach (Balkezesek item in playersInEvszam)
            {
                atlagSuly += item.Suly;
            }
            Console.WriteLine($"\n6.feladat: {Math.Round(atlagSuly / playersInEvszam.Count, 2)} font");

            Console.ReadLine();
        }
    }
}
