using MyModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBusinessDomain.BusinessDomain
{
    public class DisplayEmplyee2 : IDisplayEmployee
    {
        public DisplayEmplyee2()
        {

        }

        public List<EmployeeDetails> ShowEmployeeDetails()
        {
            List<EmployeeDetails> details = new List<EmployeeDetails>();
            details.Add(new EmployeeDetails { eid = 101, ename = "zzz", salary = 25000.23m });
            details.Add(new EmployeeDetails { eid = 102, ename = "Yash", salary = 852563.23m });
            details.Add(new EmployeeDetails { eid = 103, ename = "Prash", salary = 12559.23m });


            return details;
        }

        public string GetEmployeeDetails()
        {
            return "Business Domain is Success";
        }
    }
}
