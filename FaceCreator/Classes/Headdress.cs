using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Headdress:PartFace
    {
        FlyWeightImage HeaddressImage = new FlyWeightImage(7);
        public Headdress() { }
        public Headdress(int X, int Y) : base(X, Y)
        {
            HeaddressImage.GetBitmapsFromResourceFolder("headdress_");
            h = HeaddressImage.getImageBeard(0).Height;
            w = HeaddressImage.getImageBeard(0).Width;
        }
    }
}
