using injection.Models.services;
using Microsoft.AspNetCore.Mvc;

namespace injection.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : Controller
    {
      
            private readonly ISalaryCalculator _salaryCalculator;

            public SalaryController(ISalaryCalculator salaryCalculator)
            {
                _salaryCalculator = salaryCalculator;
            }

            [HttpGet("{annualSalary}")]
            public IActionResult GetSalary(double annualSalary)
            {
                double quarterlySalary = _salaryCalculator.CalculateSalary((double)annualSalary);
                return Ok(quarterlySalary);
            }
        }
    }

