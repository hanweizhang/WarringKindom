using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warring_Kingdom
{
    public partial class GamePanel : UserControl
    {
        //private int xCor;
        //private int yCor;
        private Point mouseCor;
        //private bool drag;
        //private Rectangle disRect;
        //private const int MIN_WIDTH = 800;
        //private const int MIN_HEIGHT = 450;
        private const int LAND_WIDTH = 100;
        private const int LAND_HEIGHT = 100;
        private const int LAND_NUM = 10;
        private Bitmap map;
        private Bitmap city;
        private Bitmap empty;
        private Rectangle[] landRect;
        private bool[] hasCity;
        private string username;
        private GameForm gameForm;

        public GamePanel()
        {
            InitializeComponent();
            mouseCor = new Point(0, 0);
            //drag = false;
            //this.mapPic.MouseWheel += GamePanel_MouseWheel;
            map = new Bitmap(this.mapPic.Image);
            city = new Bitmap(Properties.Resources.fortress1);
            empty = new Bitmap(Properties.Resources.empty);
            // display the map
            //disRect = new Rectangle(map.Width / 4, map.Height / 4, map.Width / 2, map.Height / 2);
            //this.mapPic.Image.Dispose();
            //this.mapPic.Image = map.Clone(disRect, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            // display cities
            getCities();
            drawCity();
        }

        public void setUser(string username)
        {
            this.username = username;
        }

        public void setForm(GameForm gameForm)
        {
            this.gameForm = gameForm;
            this.gameForm.showRefreshBtn();
        }

        private void getCities()
        {
            landRect = new Rectangle[LAND_NUM];
            hasCity = new bool[LAND_NUM];
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=zhangh; pwd=Zhw628zhw628; database=WarKing";
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();
                // get the information
                try
                {
                    String comm = "EXEC GetCity";
                    SqlCommand selectComm = new SqlCommand(comm, conn);
                    SqlDataReader reader = selectComm.ExecuteReader();
                    for (int i = 0; i < LAND_NUM; i++)
                    {
                        reader.Read();
                        landRect[i] = new Rectangle((int)reader.GetValue(0) - LAND_WIDTH / 2, (int)reader.GetValue(1) - LAND_HEIGHT/2, LAND_WIDTH, LAND_HEIGHT);
                        hasCity[i] = ((int)reader.GetValue(2))==0?false:true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void drawCity()
        {
            for (int i = 0; i < landRect.Length;i++ )
            {
                if (hasCity[i])
                {
                    Graphics.FromImage(this.mapPic.Image).DrawImage(city, landRect[i]);
                }
                else
                {
                    Graphics.FromImage(this.mapPic.Image).DrawImage(empty, landRect[i]);
                }
                
            }
        }

        private void GamePanel_MouseEnter(object sender, EventArgs e)
        {
            #region Code for Zoom
            this.mapPic.Focus();
            #endregion
        }
        
        /**
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
        */
        /**
        private void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {
            #region Code for Drag
            if (e.Button == MouseButtons.Left)
            {
                mouseCor.X = e.X;
                mouseCor.Y = e.Y;
                drag = true;
            } 
            #endregion
        }
        */

        /**
        private void GamePanel_MouseMove(object sender, MouseEventArgs e)
        {
            #region Code for Drag
            if (drag)
            {
                int deltaX = e.X - mouseCor.X;
                int deltaY = e.Y - mouseCor.Y;
                if ((disRect.X - deltaX) > 0)
                {
                    if ((disRect.X - deltaX) < map.Width - disRect.Width)
                    {
                        for (int i = 0; i < cityRect.Length; i++)
                        {
                            cityRect[i].X -= deltaX;
                        }
                        disRect.X -= deltaX;
                    }
                    else
                    {
                        for (int i = 0; i < cityRect.Length; i++)
                        {
                            cityRect[i].X -= disRect.X - (map.Width - disRect.Width);
                        }
                        disRect.X = map.Width - disRect.Width;
                    }
                }
                else
                {
                    for (int i = 0; i < cityRect.Length; i++)
                    {
                        cityRect[i].X -= disRect.X;
                    }
                    disRect.X = 0;
                }
                if ((disRect.Y - deltaY) > 0)
                {
                    if ((disRect.Y - deltaY) < map.Height - disRect.Height)
                    {
                        for (int i = 0; i < cityRect.Length; i++)
                        {
                            cityRect[i].Y -= deltaY;
                        }
                        disRect.Y -= deltaY;
                    }
                    else
                    {
                        for (int i = 0; i < cityRect.Length; i++)
                        {
                            cityRect[i].Y -= disRect.Y - (map.Height - disRect.Height);
                        }
                        disRect.Y = map.Height - disRect.Height;
                    }
                }
                else
                {
                    for (int i = 0; i < cityRect.Length; i++)
                    {
                        cityRect[i].Y -= disRect.Y;
                    }
                    disRect.Y = 0;
                }
                this.mapPic.Image.Dispose();
                this.mapPic.Image = map.Clone(disRect, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                mouseCor.X = e.X;
                mouseCor.Y = e.Y;
            } 
            #endregion
            drawCity();
        }
        */
        /**
        private void GamePanel_MouseUp(object sender, MouseEventArgs e)
        {
            #region Code for Drag
            if (e.Button == MouseButtons.Left)
            {
                drag = false;
            } 
            #endregion
        }
        */

        private void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    // connect to the server
                    String connectStr = "server=titan.csse.rose-hulman.edu; uid=zhangh; pwd=Zhw628zhw628; database=WarKing";
                    SqlConnection conn = new SqlConnection(connectStr);
                    conn.Open();
                    // get the information
                    try
                    {
                        String comm = "EXEC CheckLandOrCity @x="+e.X+", @y="+e.Y+", @username="+this.username;
                        SqlCommand selectComm = new SqlCommand(comm, conn);
                        SqlDataReader reader = selectComm.ExecuteReader();
                        if (reader.Read())
                        {
                            switch ((int)reader.GetValue(0))
                            {
                                case 0: disOwnCity((string)reader.GetValue(1)); break;
                                case 1: disOtherCity((string)reader.GetValue(1)); break;
                                case 2: disEmptyLand((string)reader.GetValue(1)); break;
                                default: break;
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void disEmptyLand(string LandName)
        {
            Form newCity = new NewCityForm(this.username, LandName, this.gameForm);
            newCity.ShowDialog();
        }

        private void disOtherCity(string cityName)
        {
            Form otherCity = new OtherCityInfo(this.username, cityName, this.gameForm);
            otherCity.ShowDialog();
        }

        private void disOwnCity(string cityName)
        {
            this.gameForm.setTitle(cityName);
            this.gameForm.Controls.Add(new CityPanel(cityName, this.gameForm));
            this.gameForm.hideRefreshBtn();
            this.Dispose();
        }

    }
}
