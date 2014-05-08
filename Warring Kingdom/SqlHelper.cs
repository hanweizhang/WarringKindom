using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warring_Kingdom
{
    class SqlHelper
    {
        private SqlConnection conn;

        public SqlHelper()
        {
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=zhangh; pwd=Zhw628zhw628; database=WarKing";
                conn = new SqlConnection(connectStr);
                conn.Open();
                MessageBox.Show("Success");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Close(){
            conn.Close();
        }
    }
}
