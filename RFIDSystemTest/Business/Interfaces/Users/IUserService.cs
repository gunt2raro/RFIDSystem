using RFIDSystemTest.Data;
using RFIDSystemTest.Data.Users;
using System.Collections.Generic;

namespace RFIDSystemTest.Business.Interfaces
{
    /// <summary>
    /// Interface User service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public interface IUserService
    {
        IList<User> getAll( UserSystem user_log );
        User loginUser( User user );
        Rol geUserPermissions( User user, UserSystem user_log );
        bool setUserSession( User user, UserSystem user_log );

    }// End of IUserService interface
}
