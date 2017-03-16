using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDawg.Model
{
    public class Tilmeld
    {
        public string Navn { get; set; }
       // public string Efternavn { get; set; }

        public int Tal {get; set;}

        //public bool PrøvetYoga { get; set; }

        public Tilmeld(string navn, int tal)
        {
            this.Navn = navn;
            //this.Efternavn = efternavn;
            this.Tal = tal;
        }


        public override string ToString()
        {
            return $"Navn: {Navn} {Tal} ";
        }

    }
}
