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
using System.Threading;

namespace Warring_Kingdom
{
    public partial class CityPanel : UserControl
    {
        //private GamePanel gamePanel;
        private GameForm gameForm;
        private const int LAND_WIDTH = 269;
        private const int LAND_HEIGHT = 109;
        private const int BDPIC_WIDTH = 111;
        private const int BDPIC_HEIGHT = 86;
        private const int LANDPIC_WIDTH = 436;
        private const int LANDPIC_HEIGHT = 158;
        public Rectangle[] checkMouse = new Rectangle[9];
        private Point[] centerPoint = new Point[9];
        private bool[] isEmpty = new bool[9];
        private PictureBox[] picBox = new PictureBox[9];
        private string cityName;
        //private Bitmap[] bdPic = new Bitmap[9];
        //private Thread paintThread;
        //private delegate void myInvoke();
        //private bool paintEnd;

        public CityPanel(string cityName, GameForm gameForm)
        {
            InitializeComponent();
            this.constructionPanel1.Hide();
            // initialize check mouse rectangle
            //checkMouse[0] = new Rectangle(661, 179, LAND_WIDTH,LAND_HEIGHT);
            //checkMouse[1] = new Rectangle(349, 292, LAND_WIDTH, LAND_HEIGHT);
            //checkMouse[2] = new Rectangle(42, 412, LAND_WIDTH, LAND_HEIGHT);
            //checkMouse[3] = new Rectangle(981, 288, LAND_WIDTH, LAND_HEIGHT);
            //checkMouse[4] = new Rectangle(671, 408,LAND_WIDTH, LAND_HEIGHT);
            //checkMouse[5] = new Rectangle(354, 52, LAND_WIDTH, LAND_HEIGHT);
            //checkMouse[6] = new Rectangle(1303, 412, LAND_WIDTH, LAND_HEIGHT);
            //checkMouse[7] = new Rectangle(992, 524, LAND_WIDTH, LAND_HEIGHT);
            //checkMouse[8] = new Rectangle(687, 635, LAND_WIDTH, LAND_HEIGHT);
            // initialize the center points
            centerPoint[0] = new Point(799,235);
            centerPoint[1] = new Point(488,351);
            centerPoint[2] = new Point(178,469);
            centerPoint[3] = new Point(1116,346);
            centerPoint[4] = new Point(807,466);
            centerPoint[5] = new Point(492,581);
            centerPoint[6] = new Point(1441,465);
            centerPoint[7] = new Point(1131,581);
            centerPoint[8] = new Point(821,695);
            // initialize picture box
            picBox[0] = this.pictureBox1;
            picBox[1] = this.pictureBox2;
            picBox[2] = this.pictureBox3;
            picBox[3] = this.pictureBox4;
            picBox[4] = this.pictureBox5;
            picBox[5] = this.pictureBox6;
            picBox[6] = this.pictureBox7;
            picBox[7] = this.pictureBox8;
            picBox[8] = this.pictureBox9;

            //this.gamePanel = gamePanel;
            this.gameForm = gameForm;
            this.cityName = cityName;
            initLand(cityName);
            //paintEnd = false;
            //paintThread = new Thread(new ThreadStart(drawThread));
            //paintThread.Start();
            //drawLand();
        }

        //private void drawThread()
        //{
        //    while (!paintEnd)
        //    {
        //        this.cityPic.BeginInvoke(new myInvoke(drawLand));
        //        Thread.Sleep(1000);
        //    }

        //}

        private void initLand(string cityName)
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
                    String comm = "EXEC LoadCity @cityname='" + cityName + "'";
                    SqlCommand selectComm = new SqlCommand(comm, conn);
                    SqlDataReader reader = selectComm.ExecuteReader();
                    for (int i = 0; i < 9; i++)
                    {
                        reader.Read();
                        switch ((string)reader.GetValue(0))
                        {
                            case "barrack":
                                picBox[i].Image = new Bitmap(Properties.Resources.building1); 
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "smithy":
                                picBox[i].Image = new Bitmap(Properties.Resources.building2); 
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "archery":
                                picBox[i].Image = new Bitmap(Properties.Resources.building3); 
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "general shop":
                                picBox[i].Image = new Bitmap(Properties.Resources.building4);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "house":
                                picBox[i].Image = new Bitmap(Properties.Resources.building5);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "tavern":
                                picBox[i].Image = new Bitmap(Properties.Resources.building6);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "armory":
                                picBox[i].Image = new Bitmap(Properties.Resources.building7);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "inn":
                                picBox[i].Image = new Bitmap(Properties.Resources.building8);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "post":
                                picBox[i].Image = new Bitmap(Properties.Resources.building9);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "farm":
                                picBox[i].Image = new Bitmap(Properties.Resources.building10);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "storage":
                                picBox[i].Image = new Bitmap(Properties.Resources.building11);
                                isEmpty[i] = false;
                                checkMouse[i] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - BDPIC_WIDTH / 2, centerPoint[i].Y - BDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);
                                break;
                            case "empty":
                                picBox[i].Image = null;
                                isEmpty[i] = true;
                                checkMouse[i] = new Rectangle(LANDPIC_WIDTH / 2 - LAND_WIDTH / 2, LANDPIC_HEIGHT / 2 - LAND_HEIGHT / 2, LAND_WIDTH, LAND_HEIGHT);
                                picBox[i].Location = new System.Drawing.Point(centerPoint[i].X - LANDPIC_WIDTH / 2, centerPoint[i].Y - LANDPIC_HEIGHT / 2);
                                picBox[i].Size = new System.Drawing.Size(LANDPIC_WIDTH, LANDPIC_HEIGHT);
                                break;
                            default: MessageBox.Show("Error"); break;
                        }
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //private void drawLand()
        //{
        //    //Graphics g = this.cityPic.CreateGraphics();
        //    for (int i = 0; i < 9; i++)
        //    {
        //        picBox[i].Image = bdPic[i];
        //        picBox[i].Invalidate();
        //        /**
        //        if (isEmpty[i] != true)
        //        {
        //            //g.DrawImage(bdPic[i], new Rectangle(centerPoint[i].X - BDPIC_WIDTH/2, centerPoint[i].Y - BDPIC_HEIGHT/2, BDPIC_WIDTH, BDPIC_HEIGHT));
        //            picBox[i].Image = bdPic[i];
        //        }
        //        else if(bdPic[i]!=null)
        //        {

        //            //g.DrawImage(bdPic[i], new Rectangle(centerPoint[i].X - LANDPIC_WIDTH/2, centerPoint[i].Y - LANDPIC_HEIGHT/2, LANDPIC_WIDTH, LANDPIC_HEIGHT));
        //        }
        //        */
        //    }
        //    //this.cityPic.Invalidate();
        //}

        private void backBtn_Click(object sender, EventArgs e)
        {
            //this.paintThread.Abort();
            //this.paintEnd = true;
            this.gameForm.refreshMap();
            this.gameForm.setTitle("Map");
            this.Dispose();
        }
        private void CityPanel_MouseEnter(object sender, EventArgs e)
        {
            //this.cityPic.Focus();
            this.Focus();
        }

        //private void CityPanel_MouseLeave(object sender, EventArgs e)
        //{
        //    this.paintThread.Abort();
        //    paintEnd = true;
        //}

        private void CityPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender.Equals(pictureBox1))
            {
                updatePicBox(1, e);
            }
            else if (sender.Equals(pictureBox2))
            {
                updatePicBox(2, e);
            }
            else if (sender.Equals(pictureBox3))
            {
                updatePicBox(3, e);
            }
            else if (sender.Equals(pictureBox4))
            {
                updatePicBox(4, e);
            }
            else if (sender.Equals(pictureBox5))
            {
                updatePicBox(5, e);
            }
            else if (sender.Equals(pictureBox6))
            {
                updatePicBox(6, e);
            }
            else if (sender.Equals(pictureBox7))
            {
                updatePicBox(7, e);
            }
            else if (sender.Equals(pictureBox8))
            {
                updatePicBox(8, e);
            }
            else if (sender.Equals(pictureBox9))
            {
                updatePicBox(9, e);
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    if (isEmpty[i])
                    {
                        picBox[i].Image = null;
                    }
                }
            }
        }

        private void updatePicBox(int index, MouseEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (isEmpty[i] && checkMouse[i].Contains(e.X, e.Y))
                {
                    if (i == index - 1)
                    {
                        // highlight
                        picBox[index - 1].Image = new Bitmap(Properties.Resources.building_highlight);
                    }
                    else
                    {
                        if (picBox[i].Image != null)
                        {
                            picBox[i].Image = null;
                        }
                    }
                }
            }
        }

        private void CityPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (sender.Equals(pictureBox1))
                {
                    construct(1, e);
                }
                else if (sender.Equals(pictureBox2))
                {
                    construct(2, e);
                }
                else if (sender.Equals(pictureBox3))
                {
                    construct(3, e);
                }
                else if (sender.Equals(pictureBox4))
                {
                    construct(4, e);
                }
                else if (sender.Equals(pictureBox5))
                {
                    construct(5, e);
                }
                else if (sender.Equals(pictureBox6))
                {
                    construct(6, e);
                }
                else if (sender.Equals(pictureBox7))
                {
                    construct(7, e);
                }
                else if (sender.Equals(pictureBox8))
                {
                    construct(8, e);
                }
                else if (sender.Equals(pictureBox9))
                {
                    construct(9, e);
                }
                for (int i = 0; i < 9; i++)
                {
                    if (checkMouse[i].Contains(e.X, e.Y)&&isEmpty[i])
                    {
                        // pop up construction panel
                        //this.paintThread.Abort();
                        //paintEnd = true;
                       
                    }
                }
            }
        }

        private void construct(int index, MouseEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (isEmpty[i] && checkMouse[i].Contains(e.X, e.Y))
                {
                    if (i == index - 1)
                    {
                        this.constructionPanel1.setIndex(index);
                        this.constructionPanel1.setCity(this);
                        this.constructionPanel1.Show();
                    }
                }
            }
        }

        public void updateLand(int buildingNum, int index)
        {
            String buildingName="";
            switch (buildingNum)
            {
                case 1:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building1);
                    buildingName = "barrack";
                    break;
                case 2:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building2);
                    buildingName = "smithy";
                    break;
                case 3:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building3);
                    buildingName = "archery";
                    break;
                case 4:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building4);
                    buildingName = "general shop";
                    break;
                case 5:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building5);
                    buildingName = "house";
                    break;
                case 6:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building6);
                    buildingName = "tavern";
                    break;
                case 7:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building7);
                    buildingName = "armory";
                    break;
                case 8:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building8);
                    buildingName = "inn";
                    break;
                case 9:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building9);
                    buildingName = "post";
                    break;
                case 10:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building10);
                    buildingName = "farm";
                    break;
                case 11:
                    this.picBox[index - 1].Image = new Bitmap(Properties.Resources.building11);
                    buildingName = "storage";
                    break;
                default: break;
            }
            isEmpty[index - 1] = false;
            checkMouse[index - 1] = new Rectangle(0, 0, BDPIC_WIDTH, BDPIC_HEIGHT);
            picBox[index - 1].Location = new System.Drawing.Point(centerPoint[index - 1].X - BDPIC_WIDTH / 2, centerPoint[index - 1].Y - BDPIC_HEIGHT / 2);
            picBox[index - 1].Size = new System.Drawing.Size(BDPIC_WIDTH, BDPIC_HEIGHT);

            // update database
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=zhangh; pwd=Zhw628zhw628; database=WarKing";
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();
                try
                {
                    String sql = "EXEC ConstructBuilding @CityName='" + this.cityName + "', @BuildingLocation='" + index + "', @BuildingName='" + buildingName + "'";
                    SqlCommand selectComm = new SqlCommand(sql, conn);
                    SqlDataReader reader = selectComm.ExecuteReader();
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
}
