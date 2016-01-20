using RFIDSystemTest.Business.Interfaces.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.States;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Business.Implementations.States
{
    /// <summary>
    /// Implementation Kit State service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > States
    /// </summary>
    public class KitStateService : IKitStateService
    {
        private IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="http_service"></param>
        public KitStateService( IHttpService http_service ) {
            this.http_service = http_service;
        }// End of Constructor function
        
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
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<KitState> getAll(UserSystem user_log)
        {
            return this.http_service.JSONHttpPettitionList<KitState>( HttpMethod.GET, this.GetType().Name.ToLower().Replace( "service", "" ), null );
        }// End of getAll function

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
