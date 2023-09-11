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
        }
    }
}
