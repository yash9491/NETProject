using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModels.Model;

namespace MyBusinessDomain.BusinessDomain
{
    public class DisplayEmployee : IDisplayEmployee
    {
        public DisplayEmployee()
        {

        }

        public List<EmployeeDetails> ShowEmployeeDetails()
        {
            List<EmployeeDetails> details = new List<EmployeeDetails>();
            details.Add(new EmployeeDetails { eid = 101, ename = "Yaswanth", salary = 25000.23m });
            details.Add(new EmployeeDetails { eid = 102, ename = "Yash", salary = 852563.23m });
            details.Add(new EmployeeDetails { eid = 103, ename = "Prash", salary = 125569.23m });
            return details;
        }

        public string GetEmployeeDetails()
        {
            return "Business Domain is Success";
        }

    }
}
