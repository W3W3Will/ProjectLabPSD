using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLab.Model;
using ProjectLab.Factory;

namespace ProjectLab.Repository
{
    public class UserRepository
    {
        Database1Entities1 db = DatabaseSingleton.getInstance();

        public User addUser(string username, string email, string gender, string password)
        {
            UserFactory uf = new UserFactory();
            User u = uf.createUser(username, email, gender, password);
            db.Users.Add(u);
            db.SaveChanges();

            return u;
        }

    }
}