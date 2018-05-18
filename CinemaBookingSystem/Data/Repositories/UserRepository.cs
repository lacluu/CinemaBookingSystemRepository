using CinemaBookingSystem.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Data.Repositories
{
    public class UserRepository
    {
        private List<User> users = new List<User> {
                                                    new User("admin", 1, "avatar_1"),
                                                    new User("user", 2, "avatar_2"),
                                                    new User("sqler", 3, "avatar_3"),
                                                    new User("employer", 4, "avatar_4"),
                                                    new User("QA", 5, "avatar_5")
        };

        public List<User> GetUsers()
        {
            return users;
        }

        public void CreateUser(User user)
        {
            users.Add(user);
        }
    }
}
