using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WhyRemitApp.Utilities
{
    public class Utility
    {
        /// <summary>
        /// TODO : To Generate Image through Base 64...
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        public static Xamarin.Forms.ImageSource GetImageFromBase64(string base64)
        {
            byte[] Base64Stream = Convert.FromBase64String(base64);
            var image = Xamarin.Forms.ImageSource.FromStream(() => new MemoryStream(Base64Stream));
            return image;
        }
    }
}
