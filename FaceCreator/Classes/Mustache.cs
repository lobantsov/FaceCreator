using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Mustache:PartFace
    {
        FlyWeightImage MustacheImage = new FlyWeightImage(10);
        public Mustache() { }
        public Mustache(int X, int Y) : base(X, Y)
        {
            MustacheImage.GetBitmapsFromResourceFolder("mustache_");
            h = MustacheImage.getImageBeard(0).Height;
            w = MustacheImage.getImageBeard(0).Width;
        }
    }
}
