using CinemaWebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWebApplication.Controllers.Api
{
    [Route("api/[Controller]")]
    public class UsersApiController : Controller
    {

        public IActionResult Get()
        {
            List<User> users = new List<User>();
            User user_1 = new User
            {
                Account = "Avengers - Infinity war",
                Id = 1,
                UrlAvatar = "http://10.0.2.2:18235/images/avengers.jpg"
            };

            User user_2 = new User
            {
                Account = "Dead Pool 2",
                Id = 2,
                UrlAvatar = "http://10.0.2.2:18235/images/deadpool-2.jpg"
            };

            users.Add(user_1);
            users.Add(user_2);

            return Ok(users);
        }
        
    }
}
