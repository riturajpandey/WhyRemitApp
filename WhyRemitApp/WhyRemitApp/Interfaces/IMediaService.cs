using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WhyRemitApp.Interfaces
{
    public interface IMediaService
    {
        string ViewMediaInPdf(byte[] fileStream, string fileName);
        Task<byte[]> GetMediaInBytes(string filePath);
        Task<byte[]> ResizeImage(byte[] imageStream, float width, float height);
    }
}
