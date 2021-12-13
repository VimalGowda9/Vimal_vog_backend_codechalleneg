using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.BusinessLogic.Models;

namespace VogCodeChallenge.BusinessLogic
{
    /// <summary>
    /// FetchEmployeeDetails Interface
    /// </summary>
    public interface IFetchEmployeeDetails
    {
        /// <summary>
        /// Method to fetch all Employee Details
        /// </summary>
        /// <returns>Employee details</returns>
        IEnumerable<EmployeeModel> GetAll();

        /// <summary>
        /// Method to Fetch list of all Employee details
        /// </summary>
        /// <returns>List of Employee details</returns>
        IList<EmployeeModel> ListAll();

        /// <summary>
        /// Method to get Department details for the supplied Department Is/Address
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department Details</returns>
        DepartmentModel GetDepartmentByDepId(string departmentId);

    }
}