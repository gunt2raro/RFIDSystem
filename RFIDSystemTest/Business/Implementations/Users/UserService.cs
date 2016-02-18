using RFIDSystemTest.Business.Interfaces;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using RFIDSystemTest.Data;
using RFIDSystemTest.Data.Users;
using Newtonsoft.Json;
using RFIDSystemTest.Business.Interfaces.Users;

namespace RFIDSystemTest.Business.Implementations.Users
{
    /// <summary>
    /// Implementation User service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public class UserService : IUserService
    {
        public IHttpService http_service;
        public IUserSystemService user_system_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserService(
            IHttpService http_service, 
            IUserSystemService user_system_service
        )
        {
            this.http_service = http_service;
            this.user_system_service = user_system_service;
        }// End of Constructor function

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<User> getAll(UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<User>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.EMPTY),
                null);
        }// End of getAll function

        /// <summary>
        /// Get user permissions
        /// This returns the role of the user in the system
        /// </summary>
        /// <param name="user"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Rol geUserPermissions(User user, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getUserPermissions function

        /// <summary>
        /// Login user
        /// this will validate the username and password for access to the system
        /// Will return a user if it is valid the access
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User loginUser(User user)
        {
            // Get user from the rest service
            User user_valid = http_service.JSONHttpPettitionObject<User>(HttpMethod.POST, "user/login/", JsonConvert.SerializeObject(user));
            // Validate the user
            if (user_valid != null) {
                // Assign it to the session shit
                return setUserSession(user_valid, null) ? user_valid : null;
            }// End of user_validation
            // Return null if everything goes to the toilet
            return null;
        }// End of loginUser function

        /// <summary>
        /// Set user session
        /// this will set the user session on this side of the system
        /// </summary>
        /// <param name="user"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool setUserSession(User user, UserSystem user_log)
        {
            try {
                SessionStuff.session_object = new SessionObject();
                // Set the user session
                SessionStuff.session_object.user = user;
                // Set the rol session for permissions and shit, you know
                SessionStuff.session_object.rol = new Rol();
                // Return true if everything goes right
                return true;
            }// Verify if something goes wrong
            catch(Exception ex) {
                // Write a crapy message
                Console.Write( string.Format("{0} ----- Oh=Oh something went wrong", ex) );
                // Return false, 'couse everything goes wrong duuh
                return false;
            }// End of everything goes to the toilet
        }// End of setUserSession function

    }// End of UserRepository class
}
