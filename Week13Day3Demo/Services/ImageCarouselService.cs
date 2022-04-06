using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Week13Day3Demo.Services
{
    internal class ImageCarouselService : INotifyPropertyChanged
    {
        private readonly string[] banners =
        {
            "/Resources/employee-banner-1.png",
            "/Resources/employee-banner-2.png",
            "/Resources/employee-banner-3.png"
        };

        private int _index = 0;

        public string ImageSource => banners[_index];

        readonly Timer _timer;

        public ImageCarouselService()
        {
            _timer = new Timer(5000);
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {            
            _index++;
            if (_index >= banners.Length)
                _index = 0;

            OnPropertyChanged(nameof(ImageSource));
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
