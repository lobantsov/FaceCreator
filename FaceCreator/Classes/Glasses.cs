using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Glasses:PartFace
    {
        FlyWeightImage GlassesImage = new FlyWeightImage(5);
        public Glasses() { }
        public Glasses(int X, int Y) : base(X, Y)
        {
            GlassesImage.GetBitmapsFromResourceFolder("glasses_");
            h = GlassesImage.getImageBeard(0).Height;
            w = GlassesImage.getImageBeard(0).Width;
        }
    }
}
