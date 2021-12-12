using System.Collections.Generic;

namespace VogCodeChallenge.BusinessLogic.Models
{
    /// <summary>
    /// Department Model Class
    /// </summary>
    public class DepartmentModel
    {
        /// <summary>
        /// Business Layer Property for Department unique address
        /// </summary>
        public string DepartmentAddress { get; set; }

        /// <summary>
        /// Business Layer Property for Department name
        /// </summary>
        public string DepartmentName { get; set; }
                
        /// <summary>
        /// Business Layer Property for list of employee associated with a respective department
        /// </summary>
        public IEnumerable<EmployeeModel> Employees { get; set; }
    }
}
