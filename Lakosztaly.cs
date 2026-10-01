using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }
        public Lakosztaly(int sz, int a, int e) : base(sz,a)
        {
            this.ExtraSzolgaltatasAr = e;
        }
        public override int ArKiszamitas(int ejszakakSzama)
        {
            return (ejszakakSzama * Alapar) + ExtraSzolgaltatasAr;
        }
        public override string ToString()
        {
            return $"{base.ToString} (Extra szolgáltatás: {ExtraSzolgaltatasAr} Ft)";
        }
    }
}
