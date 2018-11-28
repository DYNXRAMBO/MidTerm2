using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidTerm2.Models;

namespace MidTerm2.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult DoCalculation(decimal left, decimal right)
        {
           
            
            return View();
        }
        [HttpPost]
        public IActionResult ShowCalculationResults()
        {
            return View();
        }
    }
}   
