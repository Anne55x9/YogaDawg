using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YogaDawg.Common;
using YogaDawg.Model;
using YogaDawg.View;
using YogaDawg.Handler;
using System.ComponentModel;

namespace YogaDawg.ViewModel
{
    public class EventViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<Event> EventList { get; set; }

        public ObservableCollection<Tilmeld> TilmeldList { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Place { get; set; }

        private DateTimeOffset _date;

        public DateTimeOffset Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private TimeSpan _time;

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string Navn { get; set; }
        //public string Efternavn { get; set; }
        public int Tal { get; set; }

        public Handler.EventHandler eh { get; set; }

        public ICommand CreateEventCommand { get; set; }
        public ICommand CreateTilmeldCommand { get; set; }
        //public ICommand DisplaySelectedEventCommand { get; set; }

        //private Event _selectedEvent;

        //public Event SelectedEvent
        //{
        //    get { return _selectedEvent; }
        //    set { _selectedEvent = value; OnPropertyChanged(nameof(SelectedEvent)); }
        //}



        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year,dt.Month,dt.Day,0,0,0,0, new TimeSpan());
            _time = new TimeSpan(dt.Hour,dt.Minute, dt.Second);

            EventList = EventCatalogSingleton.Instance.EventList;

            TilmeldList = TilmeldSingleton.Instance.TilmeldList;

            eh = new Handler.EventHandler(this);
            CreateEventCommand = new RelayCommand(eh.CreateEvent, null);
            CreateTilmeldCommand = new RelayCommand(eh.CreateTilmeld, null);
           // DisplaySelectedEventCommand = new RelayCommand(eh.DisplaySelectedEvent, null); 

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }


    }
}
