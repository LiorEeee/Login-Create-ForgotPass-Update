using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Mid_Project
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public ArrayList userData;
        protected void Page_Load(object sender, EventArgs e)
        {
            userData = (ArrayList)Session["Users"];
            if (!IsPostBack)
            {
                FirstName_TextBox.Text = ((Users)userData[0]).FirstName;
                LastName_TextBox.Text = ((Users)userData[0]).LastName;
                UserName_TextBox.Text = ((Users)userData[0]).UserName;
                ID_TextBox.Text = ((Users)userData[0]).ID;
                Gmail_TextBox.Text = ((Users)userData[0]).Gmail;
                PhoneNumber_TextBox.Text = ((Users)userData[0]).PhoneNumber;
                Password_TextBox.Text = ((Users)userData[0]).Password;
            }
        }

        protected void Edit_LinkButton_Click(object sender, EventArgs e)
        {
            FirstName_TextBox.ReadOnly = false;
            LastName_TextBox.ReadOnly = false;
            UserName_TextBox.ReadOnly = false;
            ID_TextBox.ReadOnly = false;
            Gmail_TextBox.ReadOnly = false;
            PhoneNumber_TextBox.ReadOnly = false;
            Password_TextBox.ReadOnly = false;
            Edit_LinkButton.Visible = false;
        }

        protected void UpdateInfo_Button_Click(object sender, EventArgs e)
        {
            if ((!IsValidFirstName() || !IsValidLastName() || !IsValidUserName() ||
                !IsValidID() || !IsValidGmail() || !IsValidPhoneNumber() || !IsValidPassword()) && Edit_LinkButton.Visible == false)
            {
            }
            else
            {
                if (UserName_TextBox.Text != ((Users)userData[0]).UserName)
                {
                    OleDbConnection Conn = new OleDbConnection();
                    Conn.ConnectionString = Connect.GetConnectionString();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM Users WHERE UserName = @UserName", Conn);
                    command.Parameters.AddWithValue("@UserName", UserName_TextBox.Text);

                    Conn.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Conn.Close();
                        IsGood_Label.Text = "Username Already Taken";
                    }
                    else
                    {
                        Conn.Close();
                        UpdateUser(FirstName_TextBox.Text, LastName_TextBox.Text, UserName_TextBox.Text, ID_TextBox.Text, Gmail_TextBox.Text, PhoneNumber_TextBox.Text, Password_TextBox.Text);
                        Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    UpdateUser(FirstName_TextBox.Text, LastName_TextBox.Text, UserName_TextBox.Text, ID_TextBox.Text, Gmail_TextBox.Text, PhoneNumber_TextBox.Text, Password_TextBox.Text);
                    Response.Redirect("Login.aspx");
                }
            }
        }

        public void UpdateUser(string firstName, string lastName, string userName, string id, string gmail,
                string phoneNumber, string password)
        {
            OleDbCommand command = new OleDbCommand();
            string connectionString = Connect.GetConnectionString();
            OleDbConnection Conn = new OleDbConnection(connectionString);
            command.Connection = Conn;
            command.CommandText = "UPDATE Users SET " +"Users.User_Password = '" + password + "', " +"Users.First_Name = '" + firstName + "', " +"Users.Last_Name = '" + lastName + "', " +"Users.ID = '" + id + "', " +"Users.Gmail = '" + gmail + "', " +"Users.Phone_Number = '" + phoneNumber + "', " +"Users.UserName = '" + userName + "' " +"WHERE Users.UserName = '" + ((Users)userData[0]).UserName + "'";
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@User_Password", password);
            command.Parameters.AddWithValue("@First_Name", firstName);
            command.Parameters.AddWithValue("@Last_Name", lastName);
            command.Parameters.AddWithValue("@Phone_Number", phoneNumber);
            command.Parameters.AddWithValue("@Gmail", gmail);

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        private bool IsValidFirstName()
        { return FirstName_TextBox.Text.Length > 1; }

        private bool IsValidLastName()
        { return LastName_TextBox.Text.Length > 1; }

        private bool IsValidUserName()
        { return UserName_TextBox.Text.Length > 4; }

        private bool IsValidID()
        { return System.Text.RegularExpressions.Regex.IsMatch(ID_TextBox.Text, @"^\d{8,10}$"); }

        private bool IsValidGmail()
        { return System.Text.RegularExpressions.Regex.IsMatch(Gmail_TextBox.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");}

        private bool IsValidPhoneNumber()
        { return System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber_TextBox.Text, @"^\d{10}$"); }

        private bool IsValidPassword()
        { return Password_TextBox.Text.Length >= 4; }
    }
}