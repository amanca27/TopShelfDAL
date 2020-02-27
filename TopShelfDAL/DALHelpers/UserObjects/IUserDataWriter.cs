using System;
using System.Collections.Generic;
using System.Text;
using TopShelfDAL.DatabaseContext.Tables;

namespace TopShelfDAL.DALHelpers.UserObjects
{
    public interface IUserDataWriter
    {

        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);

    }
}
