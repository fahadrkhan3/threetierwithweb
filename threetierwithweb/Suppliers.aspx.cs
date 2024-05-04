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
    public partial class WebForm4 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.S_id = txtid.Text;
            p.S_fname = txtfname.Text;
            p.S_lname = txtlname.Text;
            p.S_since = txtsince.Text;

            EmpBL obj = new EmpBL();
            obj.SInsertBL(p);

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.S_id = txtid.Text;
            p.S_fname = txtfname.Text;
            p.S_lname = txtlname.Text;
            p.S_since = txtsince.Text;

            EmpBL obj = new EmpBL();
            obj.SUpdateBL(p);

        }




        protected void btndelete_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.S_id = txtid.Text;
            p.S_fname = txtfname.Text;
            p.S_lname = txtlname.Text;
            p.S_since = txtsince.Text;


            EmpBL obj = new EmpBL();
            obj.SDeleteBL(p);

        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtsince.Text = "";
        }

        protected void btnviewall_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            EmpBL obj = new EmpBL();
            dt = obj.empSViewAllBL();
            dataGridView1.DataSource = dt;
            dataGridView1.DataBind();
        }

        protected void btnsearch_Click1(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.S_id = txtid.Text;



            EmpBL obj = new EmpBL();
            DataTable dt = obj.SSearchBL(p);

            txtfname.Text = dt.Rows[0]["S_fname"].ToString();
            txtlname.Text = dt.Rows[0]["S_lname"].ToString();
            txtsince.Text = dt.Rows[0]["S_since"].ToString();

        }
    }
}