using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrummatesV4.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrummatesV4
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        CarbajalSalinasContext dbContext = new CarbajalSalinasContext();
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var app = dbContext.Applications.FirstOrDefault();
            var user = dbContext.Users.FirstOrDefault(r =>r.AppId == app.AppId).UserName;
            return new string[] { "Hello", user };
        }
    }
}
