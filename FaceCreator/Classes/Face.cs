using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceCreator.Classes
{
    internal class Face
    {
        public static ListBox list;
        public List<PartFace> listPartFaces { get; set; }
        public PartFace partFace;
        public Face()
        {
            listPartFaces = new List<PartFace>();

        }
        public void AddingToListBox(string s, bool marker)
        {
            if (!list.Items.Contains(s) && marker)
                list.Items.Add(s);
        }

        public void show_all()
        {
            foreach (PartFace face in listPartFaces)
            {
                face.show();
            }
        }
        public void hide_all()
        {
            foreach (PartFace face in listPartFaces)
            {
                face.hide();
            }
        }

        public int is_in_part(int index)
        {
            for (int i = 0; i < listPartFaces.Count; i++)
            {
                if (listPartFaces[i].Index() == index)
                    return i;
            }
            return -1;
        }

        public void replace(PartFace part, int index)
        {
            listPartFaces[is_in_part(index)] = part;
        }
    }
}
