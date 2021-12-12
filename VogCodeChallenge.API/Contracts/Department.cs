using System.Collections.Generic;

namespace VogCodeChallenge.API.Contracts
{
    /// <summary>
    /// Department Contract Class
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Property for Department name
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Property for Department unique address
        /// </summary>
        public string DepartmentAddress { get; set; }

        /// <summary>
        /// Property for list of employee associated with a respective department
        /// </summary>
        public IEnumerable<Employee> Employees { get; set; }

    }
}
