using System;
using System.Collections.Generic;
using System.Text;
using TopShelfDAL.DatabaseContext.Tables;

namespace TopShelfDAL.DALHelpers.UserObjects
{
    public interface IUserDataGateway
    {

        User GetUser(int userId);
        void CreateUser(User user);
        void UpdateUser(User user);

        void DeleteUser(User user);


    }
}
