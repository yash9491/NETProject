using MyModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataAccess;

namespace MyBusinessDomain.BusinessDomain
{
    public class DisplayEmplyee2 : IDisplayEmployee
    {
        public DisplayEmplyee2()
        {

        }

        //public List<EmployeeDetails> ShowEmployeeDetails()
        //{
        //    List<EmployeeDetails> details = new List<EmployeeDetails>();
        //    details.Add(new EmployeeDetails { eid = 101, ename = "zzz", salary = 25000.23m });
        //    details.Add(new EmployeeDetails { eid = 102, ename = "Yash", salary = 852563.23m });
        //    details.Add(new EmployeeDetails { eid = 103, ename = "Prash", salary = 12559.23m });


        //    return details;
        //}

        public List<EmployeeDetails> ShowEmployeeDetails()
        {
            List<EmployeeDetails> details = new List<EmployeeDetails>();
            details.Add(new EmployeeDetails { eid = 101, ename = "zzz", salary = 25000.23m });
            details.Add(new EmployeeDetails { eid = 102, ename = "Yash", salary = 852563.23m });
            details.Add(new EmployeeDetails { eid = 103, ename = "Prash", salary = 12559.23m });

            var context = new masterEntities1();
            var selectResult = from s in context.Employees
                               select s.Eid;

            Console.WriteLine(selectResult);



            return details;
        }

        public string GetEmployeeDetails()
        {
            return "Business Domain is Success";
        }
      
    }
}
