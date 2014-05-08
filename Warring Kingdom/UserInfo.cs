using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Warring_Kingdom
{
    public class UserInfo
    {
        public UserInfo(string userID, string userPassword)
        {
            this.userID = userID;
            this.userPassword = userPassword;
            this.userName = "";

        }

        public void setupConnect()
        {
            SqlConnection warkingConnection = new SqlConnection("User Id=" + this.userID +";" +
                                                               "Password=" + this.userPassword + ";"+
                                                               "Server=titan.csse.rose-hulman.edu;" +
                                                               "Database=WarKing;" +
                                                               "Connection timeout=30");
            try
            {
                warkingConnection.Open();
                SqlDataReader warkingReader = null;
                SqlCommand warkingCommand = new SqlCommand("SELECT *" +
                                                            "FROM [USER]",
                                                            warkingConnection);
                warkingReader = warkingCommand.ExecuteReader();
                while (warkingReader.Read())
                {
                    this.userID += warkingReader["UserID"].ToString();
                    this.userPassword += warkingReader["UserPassword"].ToString();
                    this.userName += warkingReader["UserName"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void printSearchResult()
        {
            Console.WriteLine("UserID is " + this.userID);
            Console.WriteLine("UserPassword is " + this.userPassword);
            Console.WriteLine("UserName is " + this.userName);
        }
            



        private string userID;
        private string userPassword;
        private string userName;
    }

}
