using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Users
{
    /// <summary>
    /// Interface rol service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public interface IRolService
    {
        IList<Rol> getAll( UserSystem user_log );
        Rol getById( int rol_id, UserSystem user_log );
        Rol getByName( string name, UserSystem user_log );
        IList<Rol> getByValue( int value, UserSystem user_log );
        Rol addRol( Rol rol, UserSystem user_log );
        Rol updateRol( Rol rol, UserSystem user_log );
        bool deleteRol( Rol rol, UserSystem uesr_log );

    }// End of IRolSerivce interface
}
