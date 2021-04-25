using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculatorWebApi.Controllers
{
    
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet]
        [Route("api/calculator/add/{firstNumber:int}/{secondNumber:int}")]
        public int Add(int firstNumber, int secondNumber)
        {
            var result = _calculator.AddOrDivide("add", firstNumber, secondNumber);

            return result;
        }

        [HttpGet]
        [Route("api/calculator/divide/{firstNumber:int}/{secondNumber:int}")]
        public int Divide(int firstNumber, int secondNumber)
        {
            var result = _calculator.AddOrDivide("divide", firstNumber, secondNumber);

            return result;
        }

        [HttpGet]
        [Route("api/calculator/availableoperations")]
        public List<string> AvailableOperations()
        {
            var result = _calculator.AvailableOperations();

            return result;
        }
    }
}
