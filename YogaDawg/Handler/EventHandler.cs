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

        //public Event SelectedEvent { get; set; }

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

        public void CreateTilmeld()
        {
            Tilmeld tempTilmeld = new Tilmeld(Evm.Navn, Evm.Tal);

            tempTilmeld.Navn = Evm.Navn;
            tempTilmeld.Tal = Evm.Tal;
            //tempTilmeld.Tal = Evm.Tal;
            TilmeldSingleton.Instance.AddTilmelding(tempTilmeld);
        }

        //public void DisplaySelectedEvent()
        //{
        //    this.SelectedEvent = SelectedEvent;
        //}



    }
}
