using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Contracts
{
    public interface IEmployee
    {
        bool CreateEmployee(EmployeeCreateModel model);
        IEnumerable<EmployeeListModel> GetEmployeeList();
        EmployeeDetailsModel GetEmployeeById(int EmployeeId);
        bool EditEmployee(EmployeeEditModel model);
        bool DeleteEmployee(int EmployeeId);
    }
}
