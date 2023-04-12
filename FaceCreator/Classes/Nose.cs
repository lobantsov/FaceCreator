using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Nose:PartFace
    {
        FlyWeightImage NoseImage = new FlyWeightImage(13);
        public Nose() { }
        public Nose(int X, int Y) : base(X, Y)
        {
            NoseImage.GetBitmapsFromResourceFolder("nose_");
            w = NoseImage.getImageBeard(0).Width;
            h = NoseImage.getImageBeard(0).Height;
        }
    }
}
