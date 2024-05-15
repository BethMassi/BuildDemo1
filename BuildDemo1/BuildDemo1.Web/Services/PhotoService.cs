using BuildDemo1.Shared.Services;
using System.ComponentModel;

namespace BuildDemo1.Web.Services
{
    public class PhotoTaker : IPhoto
    {
        public string PhotoPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SourceImage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void PickPhoto()
        {
            throw new NotImplementedException();
        }

        public void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
