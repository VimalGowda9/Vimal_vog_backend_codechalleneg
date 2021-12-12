using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.BusinessLogic.Models;

namespace VogCodeChallenge.BusinessLogic
{
    public interface IFetchEmployeeDetails
    {
        IEnumerable<EmployeeModel> GetAll();

        IList<EmployeeModel> ListAll();

        DepartmentModel GetDepartment(string departmentId);

    }
}