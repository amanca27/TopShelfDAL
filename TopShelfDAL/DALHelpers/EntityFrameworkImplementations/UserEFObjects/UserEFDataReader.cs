using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopShelfDAL.DALHelpers.UserObjects;
using TopShelfDAL.DatabaseContext;
using TopShelfDAL.DatabaseContext.Tables;

namespace TopShelfDAL.DALHelpers.EntityFrameworkImplementations.UserEFObjects
{
    public class UserEFDataReader : IUserDataReader
    {
        public User GetUser(int userId)
        {
            using var dataContext = new TopShelfContext();
            return dataContext.User.Single(x => x.UserId == userId);
        }
    }
}
