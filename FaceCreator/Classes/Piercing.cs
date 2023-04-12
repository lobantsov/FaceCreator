using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Piercing:PartFace
    {
        FlyWeightImage PiercingImage = new FlyWeightImage(3);
        public Piercing() { }
        public Piercing(int X, int Y) : base(X, Y)
        {
            PiercingImage.GetBitmapsFromResourceFolder("piercing_");
            h = PiercingImage.getImageBeard(0).Height;
            w = PiercingImage.getImageBeard(0).Width;
        }
    }
}
