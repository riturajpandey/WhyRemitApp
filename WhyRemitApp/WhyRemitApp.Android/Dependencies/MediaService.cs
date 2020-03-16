using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Acr.UserDialogs;
using WhyRemitApp.Droid.Dependencies;
using WhyRemitApp.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(MediaService))]
namespace WhyRemitApp.Droid.Dependencies
{
    public class MediaService : IMediaService
    {
        public int ORIENTATION_UNKNOWN { get; private set; }
        public static int i = 0;

        public MediaService()
        {

        }
        public string ViewMediaInPdf(byte[] fileStream, string fileName)
        {
            try
            {
                if (fileStream != null)
                {
                    string externalStorageState = global::Android.OS.Environment.ExternalStorageState;
                    var externalPath = global::Android.OS.Environment.ExternalStorageDirectory.Path + "/" + fileName + ".pdf";
                    File.WriteAllBytes(externalPath, fileStream);
                    return (externalPath);
                }
                return string.Empty;
            }
            catch
            {
                Toast.MakeText(Xamarin.Forms.Forms.Context, "No Application Available to View PDF", ToastLength.Short).Show();
                return string.Empty;
            }
        }

        public async System.Threading.Tasks.Task<byte[]> GetMediaInBytes(string filePath)
        {
            //await Task.Delay(5000);
            return File.ReadAllBytes(filePath);
        }

        public async System.Threading.Tasks.Task<byte[]> ResizeImage(byte[] imageStream, float width, float height)
        {
            // Load the bitmap
            try
            {
                MemoryStream ms = new MemoryStream();
                await System.Threading.Tasks.Task.Run(() =>
                {

                    Bitmap originalImage = BitmapFactory.DecodeByteArray(imageStream, 0, imageStream.Length);
                    Bitmap resizedImage = Bitmap.CreateScaledBitmap(originalImage, (int)width, (int)height, false);

                    Bitmap finalResizedImage = GetResizedBitmap(originalImage, 0);

                    finalResizedImage.Compress(Bitmap.CompressFormat.Jpeg, 100, ms);

                    if (originalImage != null)
                    {
                        originalImage.Recycle();
                    }

                    if (finalResizedImage != null)
                    {
                        finalResizedImage.Recycle();
                    }

                    return ms.ToArray();
                });

                return ms.ToArray();
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                Toast.MakeText(Xamarin.Forms.Forms.Context, "Please reselect the image.", ToastLength.Short).Show();
                using (MemoryStream ms = new MemoryStream())
                {
                    return ms.ToArray();
                }
            }
        }

        public static Bitmap GetResizedBitmap(Bitmap bm, int orientation)
        {
            int width = bm.Width;
            int height = bm.Height;
            float scaleWidth;
            float scaleHeight;
            float getWidthPer = 0;
            float getHeightPer = 0;

            if (width > 3000 && height > 3000)
            {

                getWidthPer = ((width * 21) / 100);
                getHeightPer = ((height * 9) / 100);
            }
            else if (width > 2000 && height > 2000)
            {
                getWidthPer = ((width * 22) / 100);
                getHeightPer = ((height * 22) / 100);
            }
            else if (width > 1500 && height > 2000)
            {
                getWidthPer = ((width * 33) / 100);
                getHeightPer = ((height * 33) / 100);
            }
            else if (width < 500 && height < 500)
            {
                getWidthPer = 250;
                getHeightPer = 350;
            }
            else
            {
                getWidthPer = ((width * 33) / 100);
                getHeightPer = ((height * 33) / 100);

                if (getWidthPer > 700)
                    getWidthPer = ((width * 28) / 100);

                if (getHeightPer > 600)
                    getHeightPer = ((height * 28) / 100);
            }

            scaleWidth = ((float)getWidthPer) / width;
            scaleHeight = ((float)getHeightPer) / height;

            // CREATE A MATRIX FOR THE MANIPULATION.

            Matrix matrix = new Matrix();

            int rotate = 0;
            Android.Media.ExifInterface exif = new Android.Media.ExifInterface(WhyRemitApp.Helpers.Constants.ImgFilePath);
            var imgorientation = exif.GetAttributeInt(Android.Media.ExifInterface.TagOrientation, -1);
            switch (imgorientation)
            {
                case (int)Android.Media.Orientation.Rotate270:
                    rotate = 270;
                    i = 270;
                    break;
                case (int)Android.Media.Orientation.Rotate180:
                    rotate = 180;
                    i = 180;
                    break;
                case (int)Android.Media.Orientation.Rotate90:
                    rotate = 90;
                    i = 90;
                    break;
            }
            matrix.PostRotate(rotate);
            // RESIZE THE BIT MAP
            matrix.PostScale(scaleWidth, scaleHeight);
            //width = (int)getWidthPer;
            //height = (int)getHeightPer;
            // RECREATE THE NEW BITMAP
            Bitmap resizedBitmap = Bitmap.CreateBitmap(bm, 0, 0, width, height, matrix, true);
            return resizedBitmap;
        }
    }
     
}