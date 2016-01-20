using RFIDSystemTest.Business.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Business.Implementations.Users
{
    /// <summary>
    /// Implementation UserSystem service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public class UserSystemService : IUserSystemService
    {
        private IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="http_service"></param>
        public UserSystemService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteUser(UserSystem user, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteUser function

        /// <summary>
        /// Get by email
        /// </summary>
        /// <param name="email"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public UserSystem getByEmail(string email, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByEmail function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public UserSystem getById(int user_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by rol
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<UserSystem> getByRol(Rol rol, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByRol function

        /// <summary>
        /// Get by user name
        /// </summary>
        /// <param name="user_name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public UserSystem getByUserName(string user_name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByUserName function

        /// <summary>
        /// Log in user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public UserSystem logInUser(UserSystem user)
        {
            throw new NotImplementedException();
        }// End of logInUser function

        /// <summary>
        /// Register user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public UserSystem registerUser(UserSystem user, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of registerUser function

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public UserSystem updateUser(UserSystem user, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateUser function

    }// End of UserSystemService class
}
