using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml.Linq;
using FaceCreator.Classes;

namespace FaceCreator
{
    public partial class Form1 : Form
    {
        List<PartFace> face = new List<PartFace>();
        PartFace curent = null;
        //PartFace partFace;
        bool move = false;
        int current_index;
        public Form1()
        {
            InitializeComponent();
            PartFace.Canvas = this.CreateGraphics();
        }
        void show_all()
        {
            foreach (PartFace face in face)
            {
                face.show(current_index);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < face.Count; i++)
            {
                face[i] = null;
            }
            face.Clear();
            PartFace.Canvas.Clear(Color.White);
        }

        private void BtSizePlus_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Text = face.Count.ToString();

            for (int i = 0; i < face.Count; i++)
            {
                curent = face[i];
                if (e.X > curent.x && e.Y > curent.y && e.X < curent.x + curent.w && e.Y < curent.y + curent.h)
                {
                    curent = face[i];
                    Text = i.ToString();
                    move = true;
                    break;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
                curent.move(e.X, e.Y);
                show_all();
            }
        }
        private void BtBeard_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left*2;
            int y = ((Button)sender).Top;
            PartFace partFace = new Beard(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("beard_");
            partFace.ButtonsSummon(13);
            current_index = partFace.current_index;
            face.Add(partFace);
        }
        private void BtEyebrows_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Eyebrows(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("eyebrows_");
            partFace.ButtonsSummon(15);
            face.Add(partFace);
        }

        private void BtEyes_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Eyes(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("eyes_");
            partFace.ButtonsSummon(15);
            current_index = partFace.current_index;
            face.Add(partFace);
        }

        private void BtFace_shape_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Face_shape(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("face_shape_");
            partFace.ButtonsSummon(10);
            face.Add(partFace);
        }

        private void BtForehead_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Forehead(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("forehead_");
            partFace.ButtonsSummon(10);
            face.Add(partFace);
        }

        private void BtGlasses_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Glasses(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("glasses_");
            partFace.ButtonsSummon(5);
            face.Add(partFace);
        }

        private void BtHair_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Hair(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("hair_");
            partFace.ButtonsSummon(15);
            face.Add(partFace);
        }

        private void BtHeaddress_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Headdress(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("headdress_");
            partFace.ButtonsSummon(7);
            face.Add(partFace);
        }

        private void BtLips_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Lips(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("lips_");
            partFace.ButtonsSummon(10);
            face.Add(partFace);
        }

        private void BtMustache_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Mustache(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("mustache_");
            partFace.ButtonsSummon(10);
            face.Add(partFace);
        }

        private void BtNose_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Nose(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("nose_");
            partFace.ButtonsSummon(10);
            face.Add(partFace);
        }

        private void BtPiercing_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Piercing(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("piercing_");
            partFace.ButtonsSummon(3);
            face.Add(partFace);
        }

        private void BtTattoo_Click(object sender, EventArgs e)
        {
            int x = ((Button)sender).Left;
            int y = ((Button)sender).Top;
            PartFace partFace = new Tattoo(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("tattoo_");
            partFace.ButtonsSummon(3);
            face.Add(partFace);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            curent.move(e.KeyCode.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}