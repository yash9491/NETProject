using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModels.Model;

namespace MyBusinessDomain.BusinessDomain
{
    public interface IDisplayEmployee
    {
        string GetEmployeeDetails();
        List<EmployeeDetails> ShowEmployeeDetails();
    }
}
