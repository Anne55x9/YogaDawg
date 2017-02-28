using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDawg.Model
{
    public class TilmeldHold
    {
        public string FuldeNavn { get; set; }
        public int Postnummer { get; set; }
        public bool DyrketYogaFør { get; set; }

        public TilmeldHold(string fuldenavn, int postnummer, bool dyrketYogaFør)
        {
            this.FuldeNavn = fuldenavn;
            this.Postnummer = postnummer;
            this.DyrketYogaFør = dyrketYogaFør;
        }
        
    }
}
