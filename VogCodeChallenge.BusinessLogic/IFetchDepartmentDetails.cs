using System.Collections.Generic;
using VogCodeChallenge.BusinessLogic.Models;

namespace VogCodeChallenge.BusinessLogic
{
    /// <summary>
    /// FetchDepartmentDetails Interface
    /// </summary>
    public interface IFetchDepartmentDetails
    {
        /// <summary>
        /// Method to fetch list of all Departments and its respective employee details
        /// </summary>
        /// <returns>List of Department model</returns>
        IList<DepartmentModel> GetAllDepartments();
    }
}