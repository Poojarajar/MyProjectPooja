﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RountingASPNETCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //[Route("Emp/All")]
        //[HttpGet]
        //public string GetAllEmployees()
        //{
        //    return "Response from GetAllEmployees Method";
        //}
        //[Route("Emp/ById/{Id}")]
        //[HttpGet]
        //public string GetEmployeeById(int Id)
        //{
        //    return $"Response from GetEmployeeById Method Id: {Id}";
        //}



        
[HttpGet]
        public string GetAllEmployees()
        {
            return "Response from GetAllEmployees Method";
        }
        [HttpGet]
        public string GetEmployeeById(int Id)
        {
            return $"Response from GetEmployeeById Method Id: {Id}";
        }
    }


}

