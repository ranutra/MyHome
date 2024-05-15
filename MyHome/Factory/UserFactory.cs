using MyHome.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHome.Factory
{
    public class UserFactory
    {
        public static User createUser(int id, string email, string password, string fullName, string description)
        {
            User user = new User
            {
                Id = id,
                Email = email,
                Password = password,
                Fullname = fullName,
                Description = description
            };
            return user;
        }
    }
}