using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using BusinessLayer;
using Props;

namespace threetierwithweb
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtid.Text;
            p.Prod_name = txtname.Text;
            p.Prod_price = txtprice.Text;
            p.Prod_quantity = txtquantity.Text;

            EmpBL obj = new EmpBL();
            obj.empPInsertBL(p);

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtid.Text;
            p.Prod_name = txtname.Text; 
            p.Prod_price = txtprice.Text;
            p.Prod_quantity = txtquantity.Text;

            EmpBL obj = new EmpBL();
            obj.empPUpdateBL(p);

        }

       


        protected void btndelete_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtid.Text;
            p.Prod_name = txtname.Text;
            p.Prod_price = txtprice.Text;
            p.Prod_quantity = txtquantity.Text;


            EmpBL obj = new EmpBL();
            obj.empPDeleteBL(p);

        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
        }

        protected void btnviewall_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            EmpBL obj = new EmpBL();
            dt = obj.empPViewAllBL();
            dataGridView1.DataSource = dt;
            dataGridView1.DataBind();
        }

        protected void btnsearch_Click1(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtid.Text;



            EmpBL obj = new EmpBL();
            DataTable dt = obj.empPSearchBL(p);

            txtname.Text = dt.Rows[0]["Prod_name"].ToString();
            txtprice.Text = dt.Rows[0]["Prod_price"].ToString();
            txtquantity.Text = dt.Rows[0]["Prod_quantity"].ToString();


        }
    }
}