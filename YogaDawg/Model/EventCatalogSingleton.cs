using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDawg.Model
{
    class EventCatalogSingleton: INotifyPropertyChanged   
    {
        public ObservableCollection<Event> EventList { get; set; }

        public EventCatalogSingleton()
        {
            this.EventList.Add(new Event(20,"Yogi1", "Flow", "KBH"));
            this.EventList.Add(new Event(10, "Yogi2", "Hatcha", "KBH"));
        }

        

        public void AddEvent(Event NyEvent)
        {
            EventList.Add(NyEvent);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
