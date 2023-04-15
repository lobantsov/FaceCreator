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
        PartFace current = null;
        bool move = false;
        public Form1()
        {
            InitializeComponent();
            PartFace.Canvas = this.CreateGraphics();
            PartFace.list = listBox1;
        }
        void show_all()
        {
            foreach (PartFace face in face)
            {
                face.show();
            }
        }
        void ValidateMarker()
        {
            for (int i = 0; i < face.Count; i++)
            {
                if (!face[i].marker)
                {
                    face.Remove(face[i]);
                }
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PartFace face in face)
                face.ClearComponents();
            face.Clear();
            listBox1.Items.Clear();
            PartFace.Canvas.Clear(Color.White);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Text = face.Count.ToString();

            for (int i = 0; i < face.Count; i++)
            {
                current = face[i];
                if (e.X > current.x && e.Y > current.y && e.X < current.x + current.w && e.Y < current.y + current.h)
                {
                    current = face[i];
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
                current.move(e.X, e.Y);
                show_all();
            }
        }
        private void BtBeard_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left+900;
            int y = ((Button)sender).Top;
            PartFace partFace = new Beard(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("beard_");
            partFace.ButtonsSummon(13);
            face.Add(partFace);
        }
        private void BtEyebrows_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new Eyes(x, y);
            partFace.currentForm = this;
            partFace.ClearComponents();
            partFace.SetImages("eyes_");
            partFace.ButtonsSummon(15);
            face.Add(partFace);
        }
        private void BtFace_shape_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
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
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D) && current != null)
            {
                current.move(e);
                show_all();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<this.Controls.Count; i++)
            {
                if (Convert.ToInt32(this.Controls[i].Tag)<0)
                    this.Controls[i].KeyDown += new KeyEventHandler(Form1_KeyDown);
            }
        }
        private void BTSizePlus_Click_1(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.hide();
                current.h = (int)((double)current.h * 1.1);
                current.w = (int)((double)current.w * 1.1);
                show_all();
            }
        }
        private void BTSizeMinus_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.hide();
                current.h = (int)((double)current.h / 1.1);
                current.w = (int)((double)current.w / 1.1);
                show_all();
            }
        }
        private void MoveListItem(int index, int direction)
        {
            if (index < 0 || index >= face.Count || face.Count <= 1)
                return;

            int newIndex = index + direction;
            if (newIndex < 0 || newIndex >= face.Count)
                return;

            PartFace temp = face[index];
            face.RemoveAt(index);
            face.Insert(newIndex, temp);
        }
        private void BTMoveDownL_Click(object sender, EventArgs e)
        {
            MoveListItem(listBox1.SelectedIndex, 1);
            if (listBox1.SelectedIndex + 1 < listBox1.Items.Count)
            {
                var selectedItem = listBox1.SelectedItem;
                var selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.Items.Insert(selectedIndex + 1, selectedItem);
                listBox1.SetSelected(selectedIndex + 1, true);
            }
            show_all();
        }
        private void BTMoveUpL_Click(object sender, EventArgs e)
        {
            MoveListItem(listBox1.SelectedIndex, -1);
            if (listBox1.SelectedIndex > 0)
            {
                var selectedItem = listBox1.SelectedItem;
                var selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.Items.Insert(selectedIndex - 1, selectedItem);
                listBox1.SetSelected(selectedIndex - 1, true);
            }
            show_all() ;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (current != null)
                for (int i = face.Count - 1; i > current.current_index; i--)
                {
                    current.hide();
                    PartFace temp = current;
                    face[i] = face[i - 1];
                    face[face.Count - 1] = temp;
                    show_all();
                }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>=0)
            current = face[listBox1.SelectedIndex];
        }
    }
}