using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Mid_Project
{
    public partial class Create_Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SignUp_Button_Click(object sender, EventArgs e)
        {
            if ((!IsValidFirstName() || !IsValidLastName() || !IsValidUserName() ||
                !IsValidID() || !IsValidGmail() || !IsValidPhoneNumber() || !IsValidPassword()))
            {
            }
            else
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
                    IsSignUp.Text = "Username Already Taken";
                }
                else
                {
                    Conn.Close();
                    InsertUser(FirstName_TextBox.Text, LastName_TextBox.Text, UserName_TextBox.Text, ID_TextBox.Text, Gmail_TextBox.Text, PhoneNumber_TextBox.Text, Password_TextBox.Text);
                    Response.Redirect("Login.aspx");
                }
            }
        }

        public void InsertUser(string firstName, string lastName, string userName, string id, string gmail,
            string phoneNumber, string password)
        {
            OleDbCommand command = new OleDbCommand();
            string connectionString = Connect.GetConnectionString();
            OleDbConnection Conn = new OleDbConnection(connectionString);
            command.Connection = Conn;
            command.CommandText = "INSERT INTO Users(ID,UserName,User_Password,First_Name,Last_Name,Phone_Number,Gmail) VALUES(@id,@username,@user_password,@first_name,@last_name,@phone_number,@gmail)";
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@user_password", password);
            command.Parameters.AddWithValue("@first_name", firstName);
            command.Parameters.AddWithValue("@last_name", lastName);
            command.Parameters.AddWithValue("@phone_number", phoneNumber);
            command.Parameters.AddWithValue("@gmail", gmail);

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
        { return System.Text.RegularExpressions.Regex.IsMatch(Gmail_TextBox.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"); }

        private bool IsValidPhoneNumber()
        { return System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber_TextBox.Text, @"^\d{10}$"); }

        private bool IsValidPassword()
        { return Password_TextBox.Text.Length >= 4; }
    }
}