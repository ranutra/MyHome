using MyHome.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHome.Repository
{
    public class DatabaseSingleton
    {
        private static DBEntities db = null;

        private DatabaseSingleton() { }

        public static DBEntities GetInstance()
        {
            if (db == null)
            {
                db = new DBEntities();
            }
            return db;
        }
    }
}