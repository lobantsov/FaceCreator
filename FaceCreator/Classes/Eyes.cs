using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Eyes:PartFace
    {
            FlyWeightImage EyesImage = new FlyWeightImage(15);
            public Eyes() { }
            public Eyes(int X, int Y) : base(X, Y)
            {
                EyesImage.GetBitmapsFromResourceFolder("eyes_");
                w = EyesImage.getImageBeard(0).Width;
                h = EyesImage.getImageBeard(0).Height;
            }
    }
}
