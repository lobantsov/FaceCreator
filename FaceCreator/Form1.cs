using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FaceCreator.Classes;

namespace FaceCreator
{
    public partial class Form1 : Form
    {
        //private List<PartFace> face = PartFace.listPartFaces;
        PartFace current = null;
        bool currentMode = false;
        Face face =new Face();
        private Point point = new Point();
        public Form1()
        {
            InitializeComponent();
            PartFace.Canvas = this.CreateGraphics();
            PartFace.owner = face;
            PartFace.currentForm = this;
            Face.list = listBox1;
        }
 
        
        void ValidateMarker()
        {
            if(face.listPartFaces!=null)
            for (int i = 0; i < face.listPartFaces.Count; i++)
            {
                if (!face.listPartFaces[i].marker)
                {
                    face.listPartFaces.Remove(face.listPartFaces[i]);
                }
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSave fs = new FSave();
            fs.ShowDialog();
            if (fs.DialogResult == DialogResult.OK)
            {
                foreach (PartFace face in face.listPartFaces)
                face.ClearComponents();
                face.listPartFaces.Clear();
                listBox1.Items.Clear();
                PartFace.Canvas.Clear(Color.White);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < face.listPartFaces.Count; i++)
            {
                current = face.listPartFaces[i];
                if (e.X > current.x && e.Y > current.y && e.X < current.x + current.w && e.Y < current.y + current.h)
                {
                    current = face.listPartFaces[i];
                    Text = i.ToString();
                    break;
                }
            }
            
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //current = face[listBox1.Items.IndexOf(listBox1.Items.Count)];
        }
        private void BtBeard_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            point.X = ((Button)sender).Left+900;
            point.Y = ((Button)sender).Top+500;
            PartFace partFace = new PartFace(point.X, point.Y);
            
            partFace.ClearComponents();
            partFace.SetImages("beard_");
            partFace.ButtonsSummon(13);
            face.partFace=partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtEyebrows_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("eyebrows_");
            partFace.ButtonsSummon(15);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtEyes_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("eyes_");
            partFace.ButtonsSummon(15);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtFace_shape_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 500;
            int y = ((Button)sender).Top+200;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("face_shape_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtForehead_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("forehead_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtGlasses_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("glasses_");
            partFace.ButtonsSummon(5);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtHair_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("hair_");
            partFace.ButtonsSummon(15);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtHeaddress_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("headdress_");
            partFace.ButtonsSummon(7);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtLips_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("lips_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtMustache_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("mustache_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtNose_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("nose_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtPiercing_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
            
            partFace.ClearComponents();
            partFace.SetImages("piercing_");
            partFace.ButtonsSummon(3);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void BtTattoo_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 900;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);
           
            partFace.ClearComponents();
            partFace.SetImages("tattoo_");
            partFace.ButtonsSummon(3);
            face.partFace = partFace;
            //face.Add(partFace);
            //partFace.listPartFaces = face;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D) && current != null)
            {
                current.move(e);
                face.show_all();
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
                face.show_all();
            }
        }
        private void BTSizeMinus_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.hide();
                current.h = (int)((double)current.h / 1.1);
                current.w = (int)((double)current.w / 1.1);
                face.show_all();
            }
        }
        private void MoveListItem(int index, int direction)
        {
            if (index < 0 || index >= face.listPartFaces.Count || face.listPartFaces.Count <= 1)
                return;

            int newIndex = index + direction;
            if (newIndex < 0 || newIndex >= face.listPartFaces.Count)
                return;

            PartFace temp = face.listPartFaces[index];
            face.listPartFaces.RemoveAt(index);
            face.listPartFaces.Insert(newIndex, temp);
        }
        private void BTMoveDownL_Click(object sender, EventArgs e)
        {
            currentMode = true;
            MoveListItem(listBox1.SelectedIndex, 1);
            if (listBox1.SelectedIndex + 1 < listBox1.Items.Count)
            {
                var selectedItem = listBox1.SelectedItem;
                var selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.Items.Insert(selectedIndex + 1, selectedItem);
                listBox1.SetSelected(selectedIndex + 1, true);
            }
            face.show_all();
        }
        private void BTMoveUpL_Click(object sender, EventArgs e)
        {
            currentMode = true;
            MoveListItem(listBox1.SelectedIndex, -1);
            if (listBox1.SelectedIndex > 0)
            {
                var selectedItem = listBox1.SelectedItem;
                var selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.Items.Insert(selectedIndex - 1, selectedItem);
                listBox1.SetSelected(selectedIndex - 1, true);
            }
            face.show_all() ;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (current != null && currentMode)
                for (int i = face.listPartFaces.Count - 1; i > current.current_index; i--)
                {
                    current.hide();
                    PartFace temp = current;
                    face.listPartFaces[i] = face.listPartFaces[i - 1];
                    face.listPartFaces[face.listPartFaces.Count - 1] = temp;
                    face.show_all();
                }
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            currentMode=false;
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex <= face.listPartFaces.Count) 
                current = face.listPartFaces[listBox1.SelectedIndex];
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right&&listBox1.SelectedIndex!=null)
            {
                face.hide_all();
                if (listBox1.SelectedItem == current.Name())
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    face.listPartFaces.Remove(current);
                    if (face.listPartFaces.Count > 0)
                        current = face.listPartFaces[0];
                    else
                        current = null;
                }
                face.show_all();
            }
        }
    }
}