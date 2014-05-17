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
    public partial class CityPanel : UserControl
    {
        private GamePanel gamePanel;
        private const int LAND_WIDTH = 269;
        private const int LAND_HEIGHT = 109;
        private const int BDPIC_WIDTH = 50;
        private const int BDPIC_HEIGHT = 50;
        private const int LANDPIC_WIDTH = 50;
        private const int LANDPIC_HEIGHT = 50;
        private Rectangle[] checkMouse = new Rectangle[9];
        private Point[] centerPoint = new Point[9];
        private bool[] isEmpty = new bool[9];
        private Bitmap[] bdPic = new Bitmap[9];

        public CityPanel(string cityName, GamePanel gamePanel)
        {
            InitializeComponent();
            // initialize check mouse rectangle
            checkMouse[0] = new Rectangle(661, 179, LAND_WIDTH,LAND_HEIGHT);
            checkMouse[1] = new Rectangle(349, 292, LAND_WIDTH, LAND_HEIGHT);
            checkMouse[2] = new Rectangle(42, 412, LAND_WIDTH, LAND_HEIGHT);
            checkMouse[3] = new Rectangle(981, 288, LAND_WIDTH, LAND_HEIGHT);
            checkMouse[4] = new Rectangle(671, 408,LAND_WIDTH, LAND_HEIGHT);
            checkMouse[5] = new Rectangle(354, 52, LAND_WIDTH, LAND_HEIGHT);
            checkMouse[6] = new Rectangle(1303, 412, LAND_WIDTH, LAND_HEIGHT);
            checkMouse[7] = new Rectangle(992, 524, LAND_WIDTH, LAND_HEIGHT);
            checkMouse[8] = new Rectangle(687, 635, LAND_WIDTH, LAND_HEIGHT);
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

            this.gamePanel = gamePanel;
            initLand(cityName);
        }

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
                        switch ((string)reader.GetValue(1))
                        {
                            case "barrack": bdPic[i] = new Bitmap(Properties.Resources.building1); isEmpty[i] = false; break;
                            case "smithy": bdPic[i] = new Bitmap(Properties.Resources.building2); isEmpty[i] = false; break;
                            case "archery": bdPic[i] = new Bitmap(Properties.Resources.building3); isEmpty[i] = false; break;
                            case "general shop": bdPic[i] = new Bitmap(Properties.Resources.building4); isEmpty[i] = false; break;
                            case "house": bdPic[i] = new Bitmap(Properties.Resources.building5); isEmpty[i] = false; break;
                            case "tavern": bdPic[i] = new Bitmap(Properties.Resources.building6); isEmpty[i] = false; break;
                            case "armory": bdPic[i] = new Bitmap(Properties.Resources.building7); isEmpty[i] = false; break;
                            case "inn": bdPic[i] = new Bitmap(Properties.Resources.building8); isEmpty[i] = false; break;
                            case "post": bdPic[i] = new Bitmap(Properties.Resources.building9); isEmpty[i] = false; break;
                            case "farm": bdPic[i] = new Bitmap(Properties.Resources.building10); isEmpty[i] = false; break;
                            case "storage": bdPic[i] = new Bitmap(Properties.Resources.building11); isEmpty[i] = false; break;
                            case "empty": bdPic[i]= null; isEmpty[i] = true; break;
                            default: MessageBox.Show("Error"); break;
                        }
                    }
                    reader.Close();
                    drawLand();
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

        private void drawLand()
        {

            for (int i = 0; i < 9; i++)
            {
                if (isEmpty[i] != true)
                {
                    Graphics.FromImage(this.cityPic.Image).DrawImage(bdPic[i], new Rectangle(centerPoint[i].X - BDPIC_WIDTH, centerPoint[i].Y - BDPIC_HEIGHT, BDPIC_WIDTH, BDPIC_HEIGHT));
                }
                else if(bdPic[i]!=null)
                {
                    Graphics.FromImage(this.cityPic.Image).DrawImage(bdPic[i], new Rectangle(centerPoint[i].X - LANDPIC_WIDTH, centerPoint[i].Y - LANDPIC_HEIGHT, LANDPIC_WIDTH, LANDPIC_HEIGHT));
                }
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.gamePanel.Show();
            this.Dispose();
        }
        private void CityPanel_MouseEnter(object sender, EventArgs e)
        {
            this.cityPic.Focus();
        }

        private void CityPanel_MouseHover(object sender, EventArgs e)
        {
            bool isHightlight = false;
            for (int i = 0; i < 9; i++)
            {
                if (checkMouse[i].Contains(MousePosition.X,MousePosition.Y) && isEmpty[i] == true)
                {
                    // highlight
                    bdPic[i] = new Bitmap(Properties.Resources.building_highlight);
                    isHightlight = true;
                }
            }
            if (!isHightlight)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (isEmpty[i] == true)
                    {
                        bdPic[i] = null;
                    }
                }
            }
        }

        private void CityPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (checkMouse[i].Contains(e.X, e.Y)&&isEmpty[i]==true)
                    {
                        // pop up construction panel
                    }
                }
            }
        }
    }
}
