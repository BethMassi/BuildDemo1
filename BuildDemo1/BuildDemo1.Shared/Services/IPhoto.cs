using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildDemo1.Shared.Services
{
    public interface IPhoto : INotifyPropertyChanged
    {
        public void TakePhoto();
        public void PickPhoto();
        public string PhotoPath { get; set; }
        public string SourceImage { get; set; }
    }
}
