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
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_id = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtcell.Text;
            p.Emp_address = txtaddress.Text;

            EmpBL obj = new EmpBL();
            obj.empInsertBL(p);
            
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_id = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtcell.Text;
            p.Emp_address = txtaddress.Text;

                EmpBL obj = new EmpBL();
                obj.empUpdateBL(p);
                
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_id = txtid.Text;


            
                EmpBL obj = new EmpBL();
                DataTable dt = obj.empSearchBL(p);
                
                    txtname.Text = dt.Rows[0]["name"].ToString();
                    txtcell.Text = dt.Rows[0]["cell"].ToString();
                    txtaddress.Text = dt.Rows[0]["address"].ToString();
               

            
        }
        

        protected void btndelete_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_id = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtname.Text;
            p.Emp_address = txtaddress.Text;

           
                EmpBL obj = new EmpBL();
                obj.empDeleteBL(p);
               
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtcell.Text = "";
            txtaddress.Text = "";
        }

        protected void btnviewall_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            EmpBL obj = new EmpBL();
            dt = obj.empViewAllBL();
            dataGridView1.DataSource = dt;
            dataGridView1.DataBind();
        }
    }
}