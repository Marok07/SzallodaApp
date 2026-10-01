using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Szoba
    {
        public int SzobaSzam { get; }
        protected int alapar;
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value > 0)
                {
                    alapar = value;
                }
            }
        }
        public Szoba(int sz,int a)
        {
            this.SzobaSzam = sz;
            this.Alapar = a;
        }
        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama * Alapar;
        }
        public override string ToString()
        {
            return $"Szoba: {SzobaSzam} | Alapár: {Alapar} Ft/éj";
        }
    }
}
