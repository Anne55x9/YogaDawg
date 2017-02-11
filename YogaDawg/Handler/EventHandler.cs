using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaDawg.ViewModel;
using YogaDawg.Model;
using YogaDawg.Converter;


namespace YogaDawg.Handler
{
    public class EventHandler
    {
        private EventViewModel Evm { get; set; }

        public EventHandler(EventViewModel evm)
        {
            this.Evm = evm;

        }

        public void CreateEvent()
        {
            Event tempEvent = new Event(Evm.ID, Evm.Name, Evm.Description, Evm.Place);

            tempEvent.ID = Evm.ID;
            tempEvent.Name = Evm.Name;
            tempEvent.Description = Evm.Description;
            tempEvent.Place = Evm.Place;

            tempEvent.DateTime = DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(Evm.Date, Evm.Time);

            EventCatalogSingleton.Instance.AddEvent(tempEvent);
           
        }
    }
}
