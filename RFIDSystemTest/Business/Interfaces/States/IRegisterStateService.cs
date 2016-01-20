using RFIDSystemTest.Data.States;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.States
{
    /// <summary>
    /// Interface Register State service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > States
    /// </summary>
    public interface IRegisterStateService
    {
        IList<RegisterState> getAll( UserSystem user_log );
        RegisterState getById( int register_state_id, UserSystem user_log );
        RegisterState getByName( string name, UserSystem user_log );
        RegisterState addRegisterState( RegisterState register_state, UserSystem user_log );
        RegisterState updateRegisterState( RegisterState register_state, UserSystem user_log );
        bool deleteRegisterState( RegisterState register_state, UserSystem user_log );

    }// End fo IRegisterStateService interface
}
