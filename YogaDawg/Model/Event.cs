using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDawg.Model
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        public Event(int id, string name, string description, string place,DateTime dateTime)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Place = place;
            this.DateTime = dateTime;
        }

        public override string ToString()
        {
            return ($"Event Id er: {ID}, Event navn er: {Name}, Event Beskrivelse: {Description}, Sted: {Place}, Dato og Tid: {DateTime}.");
        }

    }
}
