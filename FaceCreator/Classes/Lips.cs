using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Lips:PartFace
    {
        FlyWeightImage LipsImage = new FlyWeightImage(10);
        public Lips() { }
        public Lips(int X, int Y) : base(X, Y)
        {
            LipsImage.GetBitmapsFromResourceFolder("lips_");
            h = LipsImage.getImageBeard(0).Height;
            w = LipsImage.getImageBeard(0).Width;
        }
    }
}
