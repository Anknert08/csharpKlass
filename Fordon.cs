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

        public string Tillverkare
        {
            set { tillverkare = value; }
            get { return tillverkare; }
        }
     
        public string Modell
        {
            set { modell = value; }
            get { return modell; }
        }
        
        public int Årsmodell
        {
            set { årsmodell = value; }
            get { return årsmodell; }
        }
        
        public string Regnummer
        {
            set { regnummer = value; }
            get { return regnummer; }
        }
       
        public string Färg
        {
            set { färg = value; }
            get { return färg; }
        }
    }
}