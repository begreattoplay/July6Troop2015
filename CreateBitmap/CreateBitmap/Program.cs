using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBitmap
{
    class Program
    {
        static void Main(string[] args)
        {
            // create bitmap
            using (var bitmap = new Bitmap(500, 500))
            {
                // randomly set 1000 pixels
                var rnd = new Random();
                for (var i = 0; i < 1000; i++)
                {
                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.Red);
                }

                // save bitmap to current directory (debug directory)
                var currentDirectory = Environment.CurrentDirectory;
                var path = Path.Combine(currentDirectory, "MyImage.png");
                bitmap.Save(path, ImageFormat.Png);
            }
        }
    }
}
