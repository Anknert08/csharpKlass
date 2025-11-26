using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharptestare
{
    public class Fordon
    {
        private string tillverkare;
        private string modell;
        private int årsmodell;
        private string regnummer;
        private string färg;

        public void SetTillverkare(string tillverkare)
        {
            this.tillverkare = tillverkare;
        }
        public string GetTillverkare()
        {
            return tillverkare;
        }
        public void SetModell(string modell)
        {
            this.modell = modell;
        }
        public string GetModell()
        {
            return modell;
        }
        public void SetÅrsmodell(int årsmodell)
        {
            this.årsmodell = årsmodell;
        }
        public int GetÅrsmodell()
        {
            return årsmodell;
        }
        public void SetRegnummer(string regnummer)
        {
            this.regnummer = regnummer;
        }
        public string GetRegnummer()
        {
            return regnummer;
        }
        public void SetFärg(string färg)
        {
            this.färg = färg;
        }
        public string GetFärg()
        {
            return färg;
        }
    }
}