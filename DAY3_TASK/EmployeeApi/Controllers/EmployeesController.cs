using EmployeeApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class EmployeesController : ControllerBase
        {
            private readonly EmployeeRepository _repository;

            public EmployeesController(EmployeeRepository repositroy)
            {
                _repository = repositroy;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                var employees = await _repository.GetAllEmployeesAsync();
                return Ok(employees);
            }
        }
    }
