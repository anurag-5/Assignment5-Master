﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5_Master.admin
{
    public partial class Course_Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Display(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=NTP-LAP-841;Initial Catalog=Employee1;Integrated Security=True;Pooling=False";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tbl_Course values('" + TextBox1.Text + "')";
            cmd.Connection = con1;
            con1.Open();
            int i = cmd.ExecuteNonQuery();
            con1.Close();
            if (i == 1)
            {
                Response.Write("<script>alert('Registration success');</script>");

            }
            else
            {
                Response.Write("<script>alert('Registration Fail');</script>");
            }
        }
    }
}