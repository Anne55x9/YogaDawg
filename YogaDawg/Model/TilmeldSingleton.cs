﻿using System;
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

        private static TilmeldSingleton _instance;

        //Tom konstruktor

        public static TilmeldSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TilmeldSingleton();
                }
                return _instance;
            }
        }

        public TilmeldSingleton()
        {
            TilmeldList = new ObservableCollection<Tilmeld>();
            this.TilmeldList.Add(new Tilmeld("Anne Sofie", 0));
            this.TilmeldList.Add(new Tilmeld("Emil", 0));
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
