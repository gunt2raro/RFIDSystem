using RFIDSystemTest.Business.Interfaces.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.States;
using RFIDSystemTest.Data.Users;

namespace RFIDSystemTest.Business.Implementations.States
{
    /// <summary>
    /// Implementation Kit State service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > States
    /// </summary>
    public class KitStateService : IKitStateService
    {
        /// <summary>
        /// Add kit state
        /// </summary>
        /// <param name="kit_state"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public KitState addKitState(KitState kit_state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of addKitState function

        /// <summary>
        /// Delete kit state
        /// </summary>
        /// <param name="kit_state"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteKitState(KitState kit_state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteKitState function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="kit_state_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public KitState getById(int kit_state_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by name
        /// </summary>
        /// <param name="kit_state_name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public KitState getByName(int kit_state_name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByName function

        /// <summary>
        /// Update kit state
        /// </summary>
        /// <param name="kit_state"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public KitState updateKitState(KitState kit_state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateKitState function

    }// End of KitStateRepository class
}
