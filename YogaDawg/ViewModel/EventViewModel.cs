using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaDawg.Model;
using YogaDawg.View;

namespace YogaDawg.ViewModel
{
    public class EventViewModel
    {
        public EventCatalogSingleton EventList { get; set; }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _place;

        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }

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

        public EventViewModel()
        {
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year,dt.Month,dt.Day,0,0,0,0, new TimeSpan());
            _time = new TimeSpan(dt.Hour,dt.Minute, dt.Second);
        }

    }
}
