using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDawg.Model
{
    public class EventCatalogSingleton: INotifyPropertyChanged   
    {
        public ObservableCollection<Event> EventList { get; set; }

        private static EventCatalogSingleton _instance;

        //Tom konstruktor

        public static EventCatalogSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EventCatalogSingleton();
                }
                return _instance;
            }
        }

        public EventCatalogSingleton()
        {
            EventList = new ObservableCollection<Event>();
            this.EventList.Add(new Event(20, "Yogi1", "Flow", "KBH"));
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
