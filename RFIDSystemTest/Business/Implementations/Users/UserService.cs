using RFIDSystemTest.Business.Interfaces;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Implementations.Users
{
    /// <summary>
    /// Implementation User service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public class UserService : IUserService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

    }// End of UserRepository class
}
