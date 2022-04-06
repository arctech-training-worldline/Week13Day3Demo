using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Day3Demo.Models
{
    public class Person : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int _age;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Age 
        { 
            get
            {
                return _age;
            }

            set
            {
                _age = value;

                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsValidAge)));

                // Inform WPF, please update bindings of IsValidAge property
                // 1. Implement interface INotifyPropertyChanged in the data class 
                // 2. Raise the PropertyChanged event with the 2nd parameter indicating the property name to notify
            }
        }

        public string Comment { get; set; }

        public bool IsValidAge => Age >= 18;
    }
}
