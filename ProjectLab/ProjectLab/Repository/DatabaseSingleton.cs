using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLab.Model;

namespace ProjectLab.Repository
{
    public class DatabaseSingleton
    {
        private static Database1Entities1 db = null; 
        private DatabaseSingleton()
        {

        }

        public static Database1Entities1 getInstance()
        {
            if(db == null)
            {
                db = new Database1Entities1();
            }
            

            return db;
            
        }
    }
}