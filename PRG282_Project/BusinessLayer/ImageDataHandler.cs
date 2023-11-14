using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.BusinessLayer
{
    internal class ImageDataHandler
    {
        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public Image ImageFromByteArray(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image picture = Image.FromStream(ms);
                return picture;
            }
        }
    }
}
