using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDawg.Model
{
    class EventCatalogSingleton 
    {
        public ObservableCollection<Event> EventList { get; set; }

        public EventCatalogSingleton()
        {
            this.EventList.Add(new Event(20,"Yogi1", "Flow", "KBH"));
            this.EventList.Add(new Event(10, "Yogi2", "Hatcha", "KBH"));
        }

    }
}
