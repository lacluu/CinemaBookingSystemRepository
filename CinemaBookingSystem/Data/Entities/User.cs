using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBookingSystem.Data.Entities
{
    public class User
    {
        private String Account { get; set; }
        private int Id { get; set; }
        private String UrlAvatar { get; set; }

        public User(String account, int id, String urlAvatar)
        {
            this.Account = account;
            this.Id = id;
            this.UrlAvatar = urlAvatar;
        }
    }
}
