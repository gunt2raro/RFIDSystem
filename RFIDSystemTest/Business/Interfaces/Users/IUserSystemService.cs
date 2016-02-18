using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Users
{
    /// <summary>
    /// Interface System Service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public interface IUserSystemService
    {
        UserSystem registerUser( UserSystem user, UserSystem user_log );
        UserSystem updateUser( UserSystem user, UserSystem user_log );
        bool deleteUser( UserSystem user, UserSystem user_log );
        UserSystem getById( int user_id, UserSystem user_log );
        UserSystem getByUserId( int user_id, UserSystem user_log );
        UserSystem getByEmail( string email, UserSystem user_log );
        IList<UserSystem> getByRol( Rol rol, UserSystem user_log );

    }// End of IUserSystemService interface
}
