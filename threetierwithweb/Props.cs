using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props
{
    public class EmpProps
    {
        private String emp_id;
        private String emp_name;
        private String emp_cell;
        private String emp_address;
        private String prod_id;
        private String prod_name;
        private String prod_price;
        private String prod_quantity;
        private String c_id;
        private String c_fname;
        private String c_lname;
        private String c_since;
        private String s_id;
        private String s_fname;
        private String s_lname;
        private String s_since;

        public string Emp_id { get => emp_id; set => emp_id = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }
        public string Emp_cell { get => emp_cell; set => emp_cell = value; }
        public string Emp_address { get => emp_address; set => emp_address = value; }
        public string Prod_id { get => prod_id; set => prod_id = value; }
        public string Prod_name { get => prod_name; set => prod_name = value; }
        public string Prod_price { get => prod_price; set => prod_price = value; }
        public string Prod_quantity { get => prod_quantity; set => prod_quantity = value; }
        public string C_id { get => c_id; set => c_id = value; }
        public string C_fname { get => c_fname; set => c_fname = value; }
        public string C_lname { get => c_lname; set => c_lname = value; }
        public string C_since { get => c_since; set => c_since = value; }
        public string S_id { get => s_id; set => s_id = value; }
        public string S_fname { get => s_fname; set => s_fname = value; }
        public string S_lname { get => s_lname; set => s_lname = value; }
        public string S_since { get => s_since; set => s_since = value; }
    }
}
