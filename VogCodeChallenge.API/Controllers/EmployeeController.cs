using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Contracts;
using VogCodeChallenge.BusinessLogic;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IFetchEmployeeDetails _employeeDetails;
        private readonly IMapper _mapper;

        public EmployeeController(IFetchEmployeeDetails fetchEmployeeDetails, IMapper mapper)
        {
            _employeeDetails = fetchEmployeeDetails;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employeeDetails = _employeeDetails.GetAll();
            var result = _mapper.Map<List<Employee>>(employeeDetails);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Department(string departmentId)
        {
            var department = _employeeDetails.GetDepartment(departmentId);
            var result = _mapper.Map<Department>(department);
            return Ok(result);
        }
    }
}
