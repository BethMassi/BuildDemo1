using System.Diagnostics;
using BuildDemo1.Shared.Services;

namespace BuildDemo1.Services
{
    public class PhotoTaker : PhotoService
    {
        public override async void PickPhoto()
        {
            //MAUI abstracts the device specific code for us
            FileResult? photo = await MediaPicker.Default.PickPhotoAsync();
            SetPhoto(photo);
        }
        public override async void TakePhoto()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                try
                {
                    //MAUI abstracts the device specific code for us
                    FileResult? photo = await MediaPicker.Default.CapturePhotoAsync();
                    SetPhoto(photo);
                }
                catch (FileNotFoundException ex)
                {
                    //Capture is not supported or could not be completed.
                    Debug.WriteLine(ex);
                }
            }
        }
        private async void SetPhoto(FileResult? photo)
        {
            if (photo != null)
            {
                using Stream sourceStream = await photo.OpenReadAsync();
                PhotoPath = photo.FullPath;                
                SetSourceImage(sourceStream);
            }
        }

    }
}
