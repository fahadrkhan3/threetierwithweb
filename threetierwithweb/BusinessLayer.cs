using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class EmpBL
    {
        public bool empInsertBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empInsertDAL(p);
        }
        public bool empUpdateBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empUpdateDAL(p);
        }
        public bool empDeleteBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empDeleteDAL(p);
        }
        public DataTable empSearchBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empSearchDAL(p);
        }
        public DataTable empViewAllBL()
        {
            EmpDAL obj = new EmpDAL();

            return obj.empViewAllDAL();
        }

        public bool empPInsertBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empPInsertDAL(p);
        }
        public bool empPDeleteBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empPDeleteDAL(p);
        }
        public bool empPUpdateBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empPUpdateDAL(p);
        }
        public DataTable empPSearchBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.empPSearchDAL(p);
        }
        public DataTable empPViewAllBL()
        {
            EmpDAL obj = new EmpDAL();

            return obj.empPViewAllDAL();
        }

        public bool CInsertBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.CInsertDAL(p);
        }
        public bool CDeleteBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.CDeleteDAL(p);
        }
        public bool CUpdateBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.CUpdateDAL(p);
        }
        public DataTable CSearchBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.CSearchDAL(p);
        }
        public DataTable empCViewAllBL()
        {
            EmpDAL obj = new EmpDAL();

            return obj.empCViewAllDAL();
        }
        public bool SInsertBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.SInsertDAL(p);
        }
        public bool SDeleteBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.SDeleteDAL(p);
        }
        public bool SUpdateBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.SUpdateDAL(p);
        }
        public DataTable SSearchBL(EmpProps p)
        {
            EmpDAL obj = new EmpDAL();

            return obj.SSearchDAL(p);
        }
        public DataTable empSViewAllBL()
        {
            EmpDAL obj = new EmpDAL();

            return obj.empSViewAllDAL();
        }
    }
}
