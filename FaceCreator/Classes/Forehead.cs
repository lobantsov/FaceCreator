using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Forehead:PartFace
    {
        FlyWeightImage BeardImage = new FlyWeightImage(10);
        public Forehead() { }
        public Forehead(int X, int Y) : base(X, Y)
        {
            BeardImage.GetBitmapsFromResourceFolder("forehead_");
            h = BeardImage.getImageBeard(0).Height;
            w = BeardImage.getImageBeard(0).Width;
        }
    }
}
