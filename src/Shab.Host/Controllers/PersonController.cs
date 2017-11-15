using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shab.Host.Models;

namespace Shab.Host.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet]
        public IEnumerable<Person> Get(){
            return new [] 
            {
                new Person(new PersonName("Shabbir", "Goher"), new DateOfBirth(new DateTime(1989, 9, 9)))
            };
        }
    }
}