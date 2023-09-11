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

        }
    }
}
