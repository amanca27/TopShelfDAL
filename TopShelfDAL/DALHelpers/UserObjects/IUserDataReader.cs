using System;
using System.Collections.Generic;
using System.Text;
using TopShelfDAL.DatabaseContext.Tables;

namespace TopShelfDAL.DALHelpers.UserObjects
{
    public interface IUserDataReader
    {

        User GetUser(int userId);

    }
}
