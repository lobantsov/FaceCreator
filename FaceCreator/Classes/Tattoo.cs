using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Tattoo:PartFace
    {
        FlyWeightImage TattooImage = new FlyWeightImage(3);
        public Tattoo() { }
        public Tattoo(int X, int Y) : base(X, Y)
        {
            TattooImage.GetBitmapsFromResourceFolder("tattoo_");
            h = TattooImage.getImageBeard(0).Height;
            w = TattooImage.getImageBeard(0).Width;
        }
    }
}
