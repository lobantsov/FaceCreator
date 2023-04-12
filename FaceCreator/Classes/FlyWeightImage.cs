using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class FlyWeightImage
    {
        List<Bitmap> imageList = new List<Bitmap>();
        int countImages;
        public FlyWeightImage() { }
        public FlyWeightImage(int countImages)
        {
            this.countImages = countImages;
        }
        public Bitmap getImageBeard(int index)
        {
            return imageList[index];
        }
        public void GetBitmapsFromResourceFolder(string imageName)
        {
            for (int i = 1; i <= countImages; i++)
            {
                string resourceName = $"{imageName}{i}";
                Bitmap bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
                if (bitmap != null)
                {
                    imageList.Add(bitmap);
                }
            }
        }
    }
}
