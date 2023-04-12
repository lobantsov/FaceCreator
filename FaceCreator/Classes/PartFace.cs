using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceCreator.Classes
{
      class PartFace
    {
        public static Graphics Canvas;
        int image_index;
        public int x, y, h, w;
        int countImages;
        protected FlyWeightImage images=new FlyWeightImage(15);
        protected Button[] buttontForMenu;
        public Form currentForm { get; set; }
        public PartFace() { }
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
            Canvas.DrawImage(images.getImageBeard(image_index), new Rectangle(x, y, w, h));
        }
        public void hide()
        {
            Canvas.FillRectangle(Brushes.White, new Rectangle(x, y, w, h)); ;
        }
        public void move(int dir, float delta)
        {
            hide();
            switch (dir)
            {
                case 0://left
                    x -= (int)delta; break;
            }
            show();
        }
        public void move(int X, int Y)
        {
            hide();
            x = X; y = Y;
            show();
        }
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
                buttontForMenu[i].BackgroundImage = images.getImageBeard(i);
                buttontForMenu[i].Tag = 1;
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
            show();
        }
        public virtual void ClearComponents()
        {
            for (int i = currentForm.Controls.Count - 1; i >= 0; i--)
            {
                Control control = currentForm.Controls[i];

                if (Convert.ToInt32(currentForm.Controls[i].Tag) == 1)
                {
                    currentForm.Controls.Remove(currentForm.Controls[i]);
                    control.Dispose();
                }
            }
        }
    }
}
