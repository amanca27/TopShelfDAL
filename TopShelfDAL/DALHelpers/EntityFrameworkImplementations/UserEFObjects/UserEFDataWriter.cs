using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopShelfDAL.DALHelpers.UserObjects;
using TopShelfDAL.DatabaseContext;
using TopShelfDAL.DatabaseContext.Tables;

namespace TopShelfDAL.DALHelpers.EntityFrameworkImplementations.UserEFObjects
{
    public class UserEFDataWriter : IUserDataWriter
    {
        public void CreateUser(User user)
        {
            using var dataContext = new TopShelfContext();
            dataContext.Add(user);
            dataContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            using var dataContext = new TopShelfContext();
            dataContext.User.Update(user);
            dataContext.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            using (var dataContext = new TopShelfContext())
            {
                User deletedUser = dataContext.User.Single(x => x.UserId == user.UserId);
                deletedUser.Deleted = DateTime.Now;
                dataContext.SaveChanges();
            }
        }
    }
}
