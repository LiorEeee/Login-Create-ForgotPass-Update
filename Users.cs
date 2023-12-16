using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mid_Project
{
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string ID { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public Users(string firstName, string lastName, string userName, string id, string gmail, string phoneNumber, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.ID = id;
            this.Gmail = gmail;
            this.PhoneNumber = phoneNumber;
            this.Password = password;

        }
    }
}