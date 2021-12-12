using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Database.Entities
{
    /// <summary>
    /// Department Entity Class
    /// </summary>
    public class DepartmentEntity
    {
        /// <summary>
        /// Database Layer Property for Department unique address
        /// </summary>
        [Key]
        public string DepartmentAddress { get; set; }

        /// <summary>
        /// Database Layer Property for Department name
        /// </summary>
        public string DepartmentName { get; set; }       
                
    }
}
