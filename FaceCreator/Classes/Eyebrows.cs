using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Eyebrows:PartFace
    {
        FlyWeightImage EyesbrownImage = new FlyWeightImage(15);
        public Eyebrows() { }
        public Eyebrows(int X, int Y) : base(X, Y)
        {
            EyesbrownImage.GetBitmapsFromResourceFolder("eyebrows_");
            h = EyesbrownImage.getImageBeard(0).Height;
            w = EyesbrownImage.getImageBeard(0).Width;
        }
    }
}
