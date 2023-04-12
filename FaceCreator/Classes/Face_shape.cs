using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceCreator.Classes
{
    internal class Face_shape:PartFace
    {
        FlyWeightImage Face_shapeImage = new FlyWeightImage(10);
        public Face_shape() { }
        public Face_shape(int X, int Y) : base(X, Y)
        {
            Face_shapeImage.GetBitmapsFromResourceFolder("face_shape_");
            h = Face_shapeImage.getImageBeard(0).Height;
            w = Face_shapeImage.getImageBeard(0).Width;
        }
    }
}
