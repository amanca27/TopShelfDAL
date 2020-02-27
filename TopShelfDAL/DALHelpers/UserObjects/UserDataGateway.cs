using System;
using System.Collections.Generic;
using System.Text;
using TopShelfDAL.DALHelpers.EntityFrameworkImplementations.UserEFObjects;
using TopShelfDAL.DatabaseContext.Tables;

namespace TopShelfDAL.DALHelpers.UserObjects
{
    public class UserDataGateway : IUserDataGateway
    {
        public IUserDataReader DataReader { get; set; }
        public IUserDataWriter DataWriter { get; set; }


        #region Constrtuctors

        

        public UserDataGateway(IUserDataReader dataReader, IUserDataWriter dataWriter)
        {
            DataReader = dataReader;
            DataWriter = dataWriter;
        }

        public UserDataGateway()
        {
            DataReader = new UserEFDataReader();
            DataWriter = new UserEFDataWriter();
        }

        #endregion


        #region CRUD Operations


        public User GetUser(int userId)
        {
            return DataReader.GetUser(userId);
        }

        public void CreateUser(User user)
        {
            DataWriter.CreateUser(user);
        }

        public void UpdateUser(User user)
        {
           DataWriter.UpdateUser(user);
        }

        public void DeleteUser(User user)
        {
            DataWriter.DeleteUser(user);
        }

        #endregion
    }
}
