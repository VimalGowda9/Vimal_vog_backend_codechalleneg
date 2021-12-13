using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VogCodeChallenge.API.Contracts;
using VogCodeChallenge.BusinessLogic;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : Controller
    {
        /// <summary>
        /// Private field for FetchDepartmentDetails class
        /// </summary>
        private readonly IFetchDepartmentDetails _departmentDetails;
        
        /// <summary>
        /// Private field for Mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="departmentDetails"></param>
        /// <param name="mapper"></param>
        public DepartmentController(IFetchDepartmentDetails departmentDetails, IMapper mapper)
        {
            _departmentDetails = departmentDetails;
            _mapper = mapper;
        }

        /// <summary>
        /// Action method to fetch list of Departments an its employee details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DepartmentDetails()
        {
            var departmentDetails = _departmentDetails.GetAllDepartments();
            if(departmentDetails != null && departmentDetails.Count > 0)
            {
                var result = _mapper.Map<List<Department>>(departmentDetails);
                return Ok(result);
            }
            else
            {
                return NotFound();
            }            
        }
    }
}