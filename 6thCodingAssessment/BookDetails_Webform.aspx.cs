using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace _6thCodingAssessment
{
    public partial class BookDetails_Webform : System.Web.UI.Page
    {
        BALayer obj = new BALayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            decimal price = Convert.ToDecimal(TextBox5.Text);
            obj.InsertData(id, TextBox2.Text, TextBox6.Text, TextBox4.Text, price);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            obj.DeleteData(id);
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            decimal price = Convert.ToDecimal(TextBox5.Text);
            obj.UpdateData(id, TextBox2.Text, TextBox6.Text, TextBox4.Text, price);
        }
    }
}