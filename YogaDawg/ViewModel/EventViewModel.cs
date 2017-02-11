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

namespace YogaDawg.ViewModel
{
    public class EventViewModel
    {
        public ObservableCollection<Event> EventList { get; set; }

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

        public Handler.EventHandler eh { get; set; }

        public ICommand CreateEventCommand { get; set; }

        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year,dt.Month,dt.Day,0,0,0,0, new TimeSpan());
            _time = new TimeSpan(dt.Hour,dt.Minute, dt.Second);

            EventList = EventCatalogSingleton.Instance.EventList;

            eh = new Handler.EventHandler(this);
            CreateEventCommand = new RelayCommand(eh.CreateEvent, null); 
        }



    }
}
