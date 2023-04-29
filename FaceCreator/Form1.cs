﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;
using FaceCreator.Classes;

namespace FaceCreator
{
    public partial class Form1 : Form
    {
        PartFace current = null;
        Face face = new Face();
        private Point point = new Point();

        private bool captureStarted = false;
        private bool saveMode = false;
        private Point startPoint;

        private Bitmap tmp;
        private Rectangle rec;


        public Form1()
        {
            InitializeComponent();
            PartFace.Canvas = CreateGraphics();
            PartFace.owner = face;
            PartFace.currentForm = panel1;
            Face.list = listBox1;
            //new SolidBrush(Color.Transparent);
        }

        void ValidateMarker()
        {
            if (face.listPartFaces != null)
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

        private void BtBeard_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            point.X = ((Button)sender).Left + 650;
            point.Y = ((Button)sender).Top + 600;
            PartFace partFace = new PartFace(point.X, point.Y);

            partFace.ClearComponents();
            partFace.SetImages("beard_");
            partFace.ButtonsSummon(13);
            face.partFace = partFace;
        }

        private void BtEyebrows_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 500;
            int y = ((Button)sender).Top+100;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("eyebrows_");
            partFace.ButtonsSummon(15);
            face.partFace = partFace;
        }

        private void BtEyes_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 520;
            int y = ((Button)sender).Top+185;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("eyes_");
            partFace.ButtonsSummon(15);
            face.partFace = partFace;
        }

        private void BtFace_shape_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 500;
            int y = ((Button)sender).Top + 200;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("face_shape_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
        }

        private void BtForehead_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 460;
            int y = ((Button)sender).Top-200;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("forehead_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
        }

        private void BtGlasses_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 415;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("glasses_");
            partFace.ButtonsSummon(5);
            face.partFace = partFace;
        }

        private void BtHair_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left+450;
            int y = ((Button)sender).Top-300;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("hair_");
            partFace.ButtonsSummon(15);
            face.partFace = partFace;
        }

        private void BtHeaddress_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 430;
            int y = ((Button)sender).Top-310;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("headdress_");
            partFace.ButtonsSummon(7);
            face.partFace = partFace;
        }

        private void BtLips_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 550;
            int y = ((Button)sender).Top+30;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("lips_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
        }

        private void BtMustache_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 600;
            int y = ((Button)sender).Top;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("mustache_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
        }

        private void BtNose_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left+530;
            int y = ((Button)sender).Top - 160;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("nose_");
            partFace.ButtonsSummon(10);
            face.partFace = partFace;
        }

        private void BtPiercing_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 450;
            int y = ((Button)sender).Top-110;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("piercing_");
            partFace.ButtonsSummon(3);
            face.partFace = partFace;
        }

        private void BtTattoo_Click(object sender, EventArgs e)
        {
            ValidateMarker();
            int x = ((Button)sender).Left + 550;
            int y = ((Button)sender).Top-200;
            PartFace partFace = new PartFace(x, y);

            partFace.ClearComponents();
            partFace.SetImages("tattoo_");
            partFace.ButtonsSummon(3);
            face.partFace = partFace;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D) &&
                current != null)
            {
                current.move(e);
                face.show_all();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Convert.ToInt32(this.Controls[i].Tag) < 0)
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
        private void listBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < face.listPartFaces.Count; i++)
            {
                if (face.listPartFaces[i].Name() == listBox1.SelectedItem)
                {
                    current= face.listPartFaces[i];
                }
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && listBox1.SelectedIndex != null)
            {
                if (current != null)
                {
                    face.hide_all();
                    if (listBox1.SelectedItem == current.Name() && listBox1.SelectedItem != null)
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


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveMode = true;
            Cursor = Cursors.Cross;
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //json.SaveResult(face.listPartFaces, $"{saveFileDialog1.FileName}.json");
            //}

        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string path = $"{openFileDialog1.FileName}.json";
            //    if (File.Exists(path))
            //    {
            //        face.listPartFaces.Clear();
            //    }

            //    face.listPartFaces = json.ReadFile(openFileDialog1);
            //    if (face.listPartFaces.Count > 0)
            //        face.show_all();
            //}
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            captureStarted = false;
            try
            {
                if (saveMode)
                {
                    Cursor = Cursors.Default;
                    Rectangle rect = new Rectangle(Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y), Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                    Bitmap bmp = new Bitmap(rect.Width, rect.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(rect.Location, Point.Empty, rect.Size);
                    }
                    saveFileDialog1.Filter = "PNG Files (*.png)|*.png";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        bmp.Save(saveFileDialog1.FileName);
                    }
                    Cursor = Cursors.Default;
                    rec = Rectangle.Empty;
                    saveMode = false;
                }
            }
            catch (Exception ex) { }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = PointToScreen(new Point(e.X, e.Y));

            captureStarted = true;
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
            if (captureStarted)
            {
                ControlPaint.DrawReversibleFrame(rec, this.BackColor, FrameStyle.Dashed);

                Point endPoint = PointToScreen(new Point(e.X, e.Y));

                int width = endPoint.X - startPoint.X;
                int height = endPoint.Y - startPoint.Y;

                rec = new Rectangle(startPoint.X, startPoint.Y, width, height);

                ControlPaint.DrawReversibleFrame(rec, this.BackColor, FrameStyle.Dashed);
            }
        }

    }
}