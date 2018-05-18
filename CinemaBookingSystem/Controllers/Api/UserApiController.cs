using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaBookingSystem.Data.Entities;
using CinemaBookingSystem.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBookingSystem.Controllers.Api
{
    [Route("api/UserApi")]
    public class UserApiController : Controller
    {
        UserRepository userRepository;
        [HttpGet]
        public List<User> Get()
        {
            userRepository = new UserRepository();
            
            return userRepository.GetUsers();
        }

        [HttpPost]
        public IActionResult Post([FromBody]User user) {
            userRepository = new UserRepository();
            userRepository.CreateUser(user);

            return Created("Add new user success", user);
        }
    }
}