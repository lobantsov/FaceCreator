using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace FaceCreator.Classes
{
    class PartFace
    {
        public static Graphics Canvas;
        public bool marker { get; private set; }
        public static Face owner;
        public int current_index{get;set;}
        public int x, y, h, w;
        protected FlyWeightImage images=new FlyWeightImage(15);
        protected Button[] buttontForMenu;
        private int index;
        public static Form currentForm { get; set; }
        
        public PartFace()
        {
           
        }
        public PartFace(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public void SetImages(string name)
        {
            images.GetBitmapsFromResourceFolder(name);
        }
        public void show()
        {
            Canvas.DrawImage(images.getImage(current_index), new Rectangle(x, y, w, h));
        }
        public void hide()
        {
            Canvas.FillRectangle(Brushes.White, new Rectangle(x, y, w, h)); ;
        }
        public void move(KeyEventArgs dir)
        {
            hide();
            switch (dir.KeyCode)
            {
                case Keys.A: x -= 5; break;
                case Keys.D: x += 5; break;
                case Keys.W: y -= 5; break;
                case Keys.S: y += 5; break;
            }
            show(); 
        }

        //public void move(int X, int Y)
        //{
        //    hide();
        //    x = X; y = Y;
        //    show();
        //}
        public void ButtonsSummon(int _countOfButtons)
        {
            buttontForMenu=new Button[_countOfButtons];
            int j = 0, j2 = 0;
            for (int i = 0; i < _countOfButtons; i++)
            {
                buttontForMenu[i] = new Button();
                buttontForMenu[i].Location = new Point(88 + j2 * 80, 61 + j * 80);
                buttontForMenu[i].Height = 75;
                buttontForMenu[i].Width = 75;
                buttontForMenu[i].Name = images.Name();
                buttontForMenu[i].BackgroundImage = images.getImage(i);
                buttontForMenu[i].Tag = i;
                buttontForMenu[i].BackgroundImageLayout = ImageLayout.Zoom;
                buttontForMenu[i].Click += new EventHandler(HandlerImage);
                if (i % 2 != 0)
                {
                    j++;
                    j2 = 0;
                }
                else
                    j2++;
                currentForm.Controls.Add(buttontForMenu[i]);
            }
        }
        void HandlerImage(object sender, EventArgs e)
        {
            hide();
            marker = true;
            current_index = (int)((Button)sender).Tag;
            owner.AddingToListBox(buttontForMenu[0].Name, marker);
            h=images.getImage(current_index).Height;
            w = images.getImage(current_index).Width;
            switch (buttontForMenu[0].Name)
            {
                case "beard": index = 1;break;
                case "eyebrows":index=2;break;
                case "eyes":index=3;break;
                case "face_shape":index=4;break;
                case "forehead": index = 5;break;
                case "glasses": index = 6; break;
                case "hair": index = 7;break;
                case "headdress": index = 8;break;
                case "lips":index=9;break;
                case "mustache": index = 10;break;
                case "nose":index=11;break;
                case "piercing": index = 12;break;
                case "tattoo":index=13;break;
            }

            if (owner.is_in_part(index)==-1)
            {
                owner.listPartFaces.Add(owner.partFace);
            }
            else
            {
                owner.replace(owner.partFace,index);
            }
            owner.show_all();
  
        }
        public string Name()
        {
            return buttontForMenu[0].Name;
        }

        public int Index()
        {
            return index;
        }

        public virtual void ClearComponents()
        {
            for (int i = currentForm.Controls.Count - 1; i >= 0; i--)
            {
                Control control = currentForm.Controls[i];

                if (Convert.ToInt32(currentForm.Controls[i].Tag) >= 0)
                {
                    currentForm.Controls.Remove(currentForm.Controls[i]);
                    control.Dispose();
                }
            }
        }
    }
}
