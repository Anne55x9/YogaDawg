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

        //public bool PrøvetYoga { get; set; }

        public Tilmeld(string navn)
        {
            this.Navn = navn;
        }


        public override string ToString()
        {
            return $"Navn: {Navn}";
        }

    }
}
