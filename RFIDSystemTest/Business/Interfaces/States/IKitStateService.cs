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
    /// Interface Kit State service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > States
    /// </summary>
    public interface IKitStateService
    {
        List<KitState> getAll( UserSystem user_log );
        KitState getById( int kit_state_id, UserSystem user_log );
        KitState getByName( int kit_state_name, UserSystem user_log );
        KitState addKitState( KitState kit_state, UserSystem user_log );
        KitState updateKitState( KitState kit_state, UserSystem user_log );
        bool deleteKitState( KitState kit_state, UserSystem user_log );

    }// End of IKitStateService interface
}
