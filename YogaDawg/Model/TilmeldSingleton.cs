using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDawg.Model
{
    public class TilmeldSingleton : INotifyPropertyChanged
    {
       public ObservableCollection<Tilmeld> TilmeldList { get; set; }

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

        public TilmeldSingleton()
        {
            TilmeldList = new ObservableCollection<Tilmeld>();
            this.TilmeldList.Add(new Tilmeld("Anne Sofie Wanscher"));
            this.TilmeldList.Add(new Tilmeld("Emil Bureau"));
        }

        public void AddTilmelding(Tilmeld nyTilmeld)
        {
            TilmeldList.Add(nyTilmeld);
        }



        /// <summary>
        /// INotifyPropertyChanged interface metode. 
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
