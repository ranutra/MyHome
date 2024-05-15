using MyHome.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHome.Repository
{
    public class MessageRepository
    {
        private static DBEntities db = DatabaseSingleton.GetInstance();
    }
}