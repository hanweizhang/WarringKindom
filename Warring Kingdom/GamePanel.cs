using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warring_Kingdom
{
    public partial class GamePanel : UserControl
    {
        private int xCor;
        private int yCor;
        private bool drag;
        private Rectangle disRect;
        private const int MIN_WIDTH = 800;
        private const int MIN_HEIGHT = 450;
        private Bitmap map;

        public GamePanel()
        {
            InitializeComponent();
            xCor = 0;
            yCor = 0;
            drag = false;
            this.mapPic.MouseWheel += GamePanel_MouseWheel;
            map = new Bitmap(this.mapPic.Image);
            // display the entire map at the beginning
            disRect = new Rectangle(0, 0, map.Width, map.Height);
            this.mapPic.Image.Dispose();
            this.mapPic.Image = map.Clone(disRect, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
        }

        private void GamePanel_MouseEnter(object sender, EventArgs e)
        {
            #region Code for Zoom
            this.mapPic.Focus();
            #endregion
        }
        
        private void GamePanel_MouseWheel(object sender, MouseEventArgs e)
        {
            #region Code for Zoom
            if (e.Delta > 0)
            {
                // Zoom out
                disRect.Width = (int)((disRect.Width * 1.1) <= map.Width ? (disRect.Width * 1.1) : map.Width);
                disRect.Height = (int)((disRect.Height * 1.1) <= map.Height ? (disRect.Height * 1.1) : map.Height);
                disRect.X = (int)((disRect.Width * 1.1) <= map.Width ? (e.X - (e.X - disRect.X) * 1.1) : 0);
                disRect.Y = (int)((disRect.Height * 1.1) <= map.Height ? (e.Y - (e.Y - disRect.Y) * 1.1) : 0);
                disRect.X = (disRect.X < 0) ? 0 : disRect.X;
                disRect.Y = (disRect.Y < 0) ? 0 : disRect.Y;
                disRect.X = (disRect.X > map.Width - disRect.Width) ? (map.Width - disRect.Width) : disRect.X;
                disRect.Y = (disRect.Y > map.Height - disRect.Height) ? (map.Height - disRect.Height) : disRect.X;

            }
            else if (e.Delta < 0)
            {
                // Zoom in
                disRect.Width = (int)((disRect.Width / 1.1) >= MIN_WIDTH ? (disRect.Width / 1.1) : MIN_WIDTH);
                disRect.Height = (int)((disRect.Height / 1.1) >= MIN_HEIGHT ? (disRect.Height / 1.1) : MIN_HEIGHT);
                disRect.X = (int)((disRect.Width / 1.1) >= MIN_WIDTH ? (e.X - (e.X - disRect.X) / 1.1) : (e.X - (e.X - disRect.X) * MIN_WIDTH / disRect.Width));
                disRect.Y = (int)((disRect.Height / 1.1) >= MIN_HEIGHT ? (e.Y - (e.Y - disRect.Y) / 1.1) : (e.X - (e.X - disRect.X) * MIN_HEIGHT / disRect.Height));
                disRect.X = (disRect.X < 0) ? 0 : disRect.X;
                disRect.Y = (disRect.Y < 0) ? 0 : disRect.Y;
                disRect.X = (disRect.X > map.Width - disRect.Width) ? (map.Width - disRect.Width) : disRect.X;
                disRect.Y = (disRect.Y > map.Height - disRect.Height) ? (map.Height - disRect.Height) : disRect.Y;
            }
            this.mapPic.Image.Dispose();
            this.mapPic.Image = map.Clone(disRect, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            #endregion
        } 

        private void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {
            #region Code for Drag
            if (e.Button == MouseButtons.Left)
            {
                xCor = e.X;
                yCor = e.Y;
                drag = true;
            } 
            #endregion
        }

        private void GamePanel_MouseMove(object sender, MouseEventArgs e)
        {
            #region Code for Drag
            if (drag)
            {
                int deltaX = e.X - xCor;
                int deltaY = e.Y - yCor;
                if ((disRect.X - deltaX) > 0)
                {
                    if ((disRect.X - deltaX) < map.Width - disRect.Width)
                    {
                        disRect.X -= deltaX;
                    }
                    else
                    {
                        disRect.X = map.Width - disRect.Width;
                    }
                }
                else
                {
                    disRect.X = 0;
                }
                if ((disRect.Y - deltaY) > 0)
                {
                    if ((disRect.Y - deltaY) < map.Height - disRect.Height)
                    {
                        disRect.Y -= deltaY;
                    }
                    else
                    {
                        disRect.Y = map.Height - disRect.Height;
                    }
                }
                else
                {
                    disRect.Y = 0;
                }
                this.mapPic.Image.Dispose();
                this.mapPic.Image = map.Clone(disRect, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                xCor = e.X;
                yCor = e.Y;
            } 
            #endregion
        }

        private void GamePanel_MouseUp(object sender, MouseEventArgs e)
        {
            #region Code for Drag
            if (e.Button == MouseButtons.Left)
            {
                drag = false;
            } 
            #endregion
        }

        private void mapPic_Click(object sender, EventArgs e)
        {

        }
    }
}
