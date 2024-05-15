using MyHome.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHome.Repository
{
    public class UserRepository
    {
        private static DBEntities db = DatabaseSingleton.GetInstance();
    }
}