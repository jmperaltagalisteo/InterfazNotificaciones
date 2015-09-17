using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InterfazNotificaciones.Clases
{
    class Notificaciones : INotifyPropertyChanged
    {
        private int numero1,numero2,numero3;

        public int Numero1
        {
            get { return numero1; }
            set
            {
               numero1 = value;
               OnPropertyChanged("Numero1");
               OnPropertyChanged("Resultado");
            }
        }

        public int Numero2
        {
            get { return numero2; }
            set
            {
                numero2 = value;
                OnPropertyChanged("Numero2");
                OnPropertyChanged("Resultado");
            }
        }

        public int Numero3
        {
            get { return numero3; }
            set
            {
                numero3 = value;
                OnPropertyChanged("Numero3");
                OnPropertyChanged("Resultado");
            }
        }

        public int Resultado
        {
            get { return Numero1 + Numero2 + Numero3; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
