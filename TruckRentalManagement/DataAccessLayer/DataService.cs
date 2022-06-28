using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TruckRentalManagement.DataAccessLayer.DB;

namespace TruckRentalManagement.DataAccessLayer
{
    class DataService
    {
        public static TruckEmployee Login(string username, string password)
        {
            TruckEmployee employee = null;
            using (DAD_Yvan_TruckRentalProjectContext ctx = new DAD_Yvan_TruckRentalProjectContext())
            {
                employee = ctx.TruckEmployee.Where(emp => emp.Username == username && emp.Password == password).FirstOrDefault();
            }

            return employee;
        }

        static public void AddNewEmployee(TruckEmployee emp)
        {
            using (DAD_Yvan_TruckRentalProjectContext ctx = new DAD_Yvan_TruckRentalProjectContext())
            {
                ctx.TruckEmployee.Add(emp);
                ctx.SaveChanges();
            }
        }

        static public void AddNewCustomer(TruckCustomer tc)
        {
            using (DAD_Yvan_TruckRentalProjectContext ctx = new DAD_Yvan_TruckRentalProjectContext())
            {
                ctx.TruckCustomer.Add(tc);
                ctx.SaveChanges();
            }
        }

        public static TruckCustomer searchCustomer(int cid)
        {
            TruckCustomer cust = null;
            using (DAD_Yvan_TruckRentalProjectContext ctx = new DAD_Yvan_TruckRentalProjectContext())
            {
                cust = ctx.TruckCustomer.Include(em => em.Customer).Where(emp => emp.CustomerId == cid).FirstOrDefault();
                return cust;
            }
        }

        static public void updateCustomer(TruckCustomer tc)
        {
            using (DAD_Yvan_TruckRentalProjectContext ctx = new DAD_Yvan_TruckRentalProjectContext())
            {
                ctx.Entry(tc.Customer).State = EntityState.Modified;
                ctx.Entry(tc).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static TruckEmployee searchEmployee(int eid)
        {
            TruckEmployee emp = null;
            using (DAD_Yvan_TruckRentalProjectContext ctx = new DAD_Yvan_TruckRentalProjectContext())
            {
                emp = ctx.TruckEmployee.Include(em => em.Employee).Where(emp => emp.EmployeeId == eid).FirstOrDefault();
                return emp;
            }
        }

        static public void updateEmployee(TruckEmployee te)
        {
            using (DAD_Yvan_TruckRentalProjectContext ctx = new DAD_Yvan_TruckRentalProjectContext())
            {
                ctx.Entry(te.Employee).State = EntityState.Modified;
                ctx.Entry(te).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
