using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace Mid_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public ArrayList userData;
        protected void Page_Load(object sender, EventArgs e)
        {
            userData = (ArrayList)Session["Users"];
            Session["Users"] = new ArrayList();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName_TextBox.Text) || string.IsNullOrEmpty(Password_TextBox.Text))
            { IsLogIn.Text = "Cant leave any field empty!"; }
            else
            {
                if (FindAccount(UserName_TextBox.Text, Password_TextBox.Text))
                { Response.Redirect("UpdateAccount.aspx"); }
                else
                { IsLogIn.Text = "UserName or Password are Incorrect"; }
            }
        }

        public bool FindAccount(string UserName, string Password)
        {
            OleDbConnection Conn = new OleDbConnection();
            Conn.ConnectionString = Connect.GetConnectionString();
            OleDbCommand command = new OleDbCommand("select * from Users", Conn);

            Conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (UserName == reader["UserName"].ToString() && Password == reader["User_Password"].ToString())
                {
                    Users User = new Users(reader["First_Name"].ToString(), reader["Last_Name"].ToString(), UserName, reader["ID"].ToString(), reader["Gmail"].ToString(), reader["Phone_Number"].ToString(), Password);
                    Conn.Close();
                    ((ArrayList)Session["Users"]).Add(User);
                    return true;
                }
                else
                {
                    Conn.Close();
                    return false;
                }
            }
            else
            { Conn.Close(); }
            return true;
        }
    }
}