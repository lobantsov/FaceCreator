using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Hair:PartFace
    {
        FlyWeightImage HairImage = new FlyWeightImage(15);
        public Hair() { }
        public Hair(int X, int Y) : base(X, Y)
        {
            HairImage.GetBitmapsFromResourceFolder("hair_");
            h = HairImage.getImageBeard(0).Height;
            w = HairImage.getImageBeard(0).Width;
        }
    }
}
