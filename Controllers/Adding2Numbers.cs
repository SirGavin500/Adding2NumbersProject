using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Adding2NumbersProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Adding2Numbers : ControllerBase
    {
        [HttpGet]
        public string AddTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return $" {num1} plus {num2} equals {sum}.";
        }
    }
}