using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace Mid_Project
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        static public string UserName;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CheckAccount_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName_TextBox.Text) || string.IsNullOrEmpty(Email_TextBox.Text))
            {
                IsPasswordChanged.Text = "Please fill in both UserName and Email.";
            }
            else
            {
                UserName = UserName_TextBox.Text;
                if (CheckAccount(UserName_TextBox.Text, Email_TextBox.Text))
                {
                    Title_Label.Visible = false; UserName_Label.Visible = false; UserName_TextBox.Visible = false; Email_Label.Visible = false; Email_TextBox.Visible = false; CheckAccount_Button.Visible = false;
                    ChangePassword_Label.Visible = true; ChangePassword_TextBox.Visible = true; ChangePassword_Button.Visible = true;
                    IsPasswordChanged.Text = "";
                }
                else
                {
                    IsPasswordChanged.Text = "Invalid UserName or Email.";
                }
            }
        }

        protected void ChangePassword_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ChangePassword_TextBox.Text))
            {
                IsPasswordChanged.Text = "Please Enter The New Password.";
            }
            else
            {
                if (ChangePassword(ChangePassword_TextBox.Text, UserName))
                {
                    { Response.Redirect("Login.aspx"); }
                }
            }
        }

        public bool CheckAccount(string UserName, string Email)
        {
            OleDbConnection Conn = new OleDbConnection();
            Conn.ConnectionString = Connect.GetConnectionString();
            OleDbCommand command = new OleDbCommand("select * from Users", Conn);

            Conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (UserName == reader["UserName"].ToString() && Email == reader["Gmail"].ToString())
                {
                    Conn.Close();
                    return true;
                }
                else
                {
                    Conn.Close();
                    return false;
                }
            }
            else
            {
                Conn.Close();
            }
            return true;
        }

        public bool ChangePassword(string Password, string UserName)
        {
            OleDbCommand command = new OleDbCommand();
            string connectionString = Connect.GetConnectionString();
            OleDbConnection Conn = new OleDbConnection(connectionString);
            command.Connection = Conn;
            command.CommandText = "UPDATE Users SET Users.User_Password = '"+ Password+"' WHERE (((Users.UserName) = '" +UserName+"'));";

            command.Parameters.AddWithValue("@User_Password", Password);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
            return true;
        }
    }
}