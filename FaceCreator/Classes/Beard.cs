using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Beard : PartFace
    {
        FlyWeightImage BeardImage = new FlyWeightImage(13);
        public Beard() { }
        public Beard(int X, int Y) : base(X, Y)
        {
            BeardImage.GetBitmapsFromResourceFolder("beard_");
            h = BeardImage.getImageBeard(BeardImage.GetIndex()).Height;
            w = BeardImage.getImageBeard(BeardImage.GetIndex()).Width;
        }
    }
}
