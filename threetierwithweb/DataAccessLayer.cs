using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Props;

namespace DataAccessLayer
{
    public class EmpDAL
    { // dll= dynamically link library
        public bool empInsertDAL(EmpProps p)
        {
            string q = "Insert INTO Employee VALUES('" + p.Emp_id + "', '" + p.Emp_name + "', '" + p.Emp_cell + "', '" + p.Emp_address + "') ";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool empUpdateDAL(EmpProps p)
        {
            string q = "UPDATE Employee SET name='" + p.Emp_name + "', cell='" + p.Emp_cell + "', address='" + p.Emp_address + "' WHERE empid='" + p.Emp_id + "'";

            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool empDeleteDAL(EmpProps p)
        {
            string q = "Delete from Employee where EmpID ='" + p.Emp_id + "'";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }

        public DataTable empSearchDAL(EmpProps p)
        {
            string q = "Select * From Employee where EmpID = '" + p.Emp_id + "'";
            DbConn obj = new DbConn();


            return obj.search(q);
        }
        public DataTable empViewAllDAL()
        {
            string q = "Select * From Employee";
            DbConn obj = new DbConn();


            return obj.search(q);
        }
        public bool empPInsertDAL(EmpProps p)
        {
            string q = "Insert INTO Product VALUES('" + p.Prod_id + "', '" + p.Prod_name + "', '" + p.Prod_price + "', '" + p.Prod_quantity + "') ";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool empPDeleteDAL(EmpProps p)
        {
            string q = "Delete from Product where Prod_id ='" + p.Prod_id + "'";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool empPUpdateDAL(EmpProps p)
        {
            string q = "UPDATE Product SET Prod_name='" + p.Prod_name + "', Prod_price='" + p.Prod_price + "', Prod_quantity='" + p.Prod_quantity + "' WHERE Prod_id='" + p.Prod_id + "'";

            DbConn obj = new DbConn(); 


            return obj.UDI(q);
        }
        public DataTable empPSearchDAL(EmpProps p)
        {
            string q = "Select * From Product where Prod_id = '" + p.Prod_id + "'";
            DbConn obj = new DbConn();


            return obj.search(q);
        }
        public DataTable empPViewAllDAL()
        {
            string q = "Select * From Product";
            DbConn obj = new DbConn();


            return obj.search(q);
        }
        public bool CInsertDAL(EmpProps p)
        {
            string q = "Insert INTO Customer VALUES('" + p.C_id + "', '" + p.C_fname + "', '" + p.C_lname + "', '" + p.C_since + "') ";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool CDeleteDAL(EmpProps p)
        {
            string q = "Delete from Customer where C_id ='" + p.C_id + "'";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool CUpdateDAL(EmpProps p)
        {
            string q = "UPDATE Customer SET C_fname='" + p.C_fname + "', C_lname='" + p.C_lname + "', C_since='" + p.C_since + "' WHERE C_id='" + p.C_id + "'";

            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public DataTable CSearchDAL(EmpProps p)
        {
            string q = "Select * From Customer where C_id = '" + p.C_id + "'";
            DbConn obj = new DbConn();


            return obj.search(q);
        }
        public DataTable empCViewAllDAL()
        {
            string q = "Select * From Customer";
            DbConn obj = new DbConn();


            return obj.search(q);
        }
        public bool SInsertDAL(EmpProps p)
        {
            string q = "Insert INTO Supplier VALUES('" + p.S_id + "', '" + p.S_fname + "', '" + p.S_lname + "', '" + p.S_since + "') ";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool SDeleteDAL(EmpProps p)
        {
            string q = "Delete from Supplier where S_id ='" + p.S_id + "'";
            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public bool SUpdateDAL(EmpProps p)
        {
            string q = "UPDATE Supplier SET S_fname='" + p.S_fname + "', S_lname='" + p.S_lname + "', S_since='" + p.S_since + "' WHERE S_id='" + p.S_id + "'";

            DbConn obj = new DbConn();


            return obj.UDI(q);
        }
        public DataTable SSearchDAL(EmpProps p)
        {
            string q = "Select * From Supplier where S_id = '" + p.S_id + "'";
            DbConn obj = new DbConn();


            return obj.search(q);
        }
        public DataTable empSViewAllDAL()
        {
            string q = "Select * From Supplier";
            DbConn obj = new DbConn();


            return obj.search(q);
        }

    }
}
