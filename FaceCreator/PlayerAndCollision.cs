using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    class Player
    {
        public PictureBox PlayerPic;
        public int Speed;

        public List<PictureBox> CollisionObject = new List<PictureBox>();

        public Vector Vector;
        public bool Move;

        public Player(PictureBox pic,int Speed)
        {
            this.PlayerPic = pic;
            this.Speed = Speed;
            this.Move = true;
        }

        public void KeyDown(object sender,KeyEventArgs e)
        {
            if(Move)
            {
                //Обработчик движения
                {
                    if (e.KeyCode == Keys.W)
                    {
                        Vector = Vector.Up;
                        PlayerPic.Location = new Point(PlayerPic.Location.X, PlayerPic.Location.Y - Speed);
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        Vector = Vector.Down;
                        PlayerPic.Location = new Point(PlayerPic.Location.X, PlayerPic.Location.Y + Speed);
                    }
                    if (e.KeyCode == Keys.D)
                    {
                        Vector = Vector.Right;
                        PlayerPic.Location = new Point(PlayerPic.Location.X + Speed, PlayerPic.Location.Y);
                    }
                    if (e.KeyCode == Keys.A)
                    {
                        Vector = Vector.Left;
                        PlayerPic.Location = new Point(PlayerPic.Location.X - Speed, PlayerPic.Location.Y);
                    }
                }

                //Collision
                {
                    for(int i = 0; i < CollisionObject.Count; i++)
                    {
                        if(Collision.CollisionObject(PlayerPic,CollisionObject[i]))
                        {
                            if(Vector == Vector.Up)
                            {
                                PlayerPic.Location = new Point(PlayerPic.Location.X, PlayerPic.Location.Y + Speed);
                            }
                            if (Vector == Vector.Down)
                            {
                                PlayerPic.Location = new Point(PlayerPic.Location.X, PlayerPic.Location.Y - Speed);
                            }
                            if(Vector == Vector.Right)
                            {
                                PlayerPic.Location = new Point(PlayerPic.Location.X - Speed, PlayerPic.Location.Y);
                            }
                            if(Vector == Vector.Left)
                            {
                                PlayerPic.Location = new Point(PlayerPic.Location.X + Speed, PlayerPic.Location.Y);
                            }
                        }
                    }
                }
            }
        }

    }

    enum Vector
    {
        Up,Down,Right,Left
    }

    static class Collision
    {
        public static bool CollisionObject(PictureBox pic, PictureBox obj)
        {
            if (pic.Location.X <= obj.Location.X + obj.Width && pic.Location.X >= obj.Location.X - pic.Width && pic.Location.Y + pic.Height >= obj.Location.Y && pic.Location.Y <= obj.Location.Y + obj.Height)
            {
                return true;
            }
            return false;
        }

        public static bool CollisionObject(PictureBox pic, PictureBox obj, int Coef)
        {
            if (pic.Location.X <= obj.Location.X + obj.Width && pic.Location.X >= obj.Location.X - pic.Width && pic.Location.Y <= obj.Location.Y + obj.Height + Coef && pic.Location.Y >= obj.Location.Y - obj.Height - pic.Height - Coef)
            {
                return true;
            }
            return false;
        }
    }