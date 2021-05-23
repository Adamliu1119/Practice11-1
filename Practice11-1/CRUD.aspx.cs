using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice11_1
{
    
      public partial class CRUD : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_Conn = "Data Sourse=(localdb)\\projectV13;" +
                "Initual Catalog=Test;Integrated Security=True;" +
                "TrustServerCertificate=False;" +
                "Connect Timeout=30;Encrypt=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                "User ID = sa; Password = 12345";

            SqlConnection o_Conn = new SqlConnection(o_Conn);
            try
            {
                o_Conn.Open();
                SqlConnection o_Conn = new SqlCommand("Update Users set Birthday= '2021/05/18'" +
                   " where Name=N'狗狗旭'", o_Conn);

                o_Com.ExecuteNonQuery();
                o_Conn.Close();
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        

        }
    }
}