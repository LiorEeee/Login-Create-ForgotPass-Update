using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace Mid_Project
{
    public class Connect
    {
        public static string GetConnectionString()
        {
            string FILE_NAME = "Project_Database.accdb";
            string Location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILE_NAME);
            string ConnectionString = @"provider=Microsoft.ACE.OLEDB.16.0; data source =" + Location;
            return ConnectionString;
        }
    }
}