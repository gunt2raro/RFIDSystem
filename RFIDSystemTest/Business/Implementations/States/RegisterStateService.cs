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
    /// Implementation Register State service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > States
    /// </summary>
    public class RegisterStateService : IRegisterStateService
    {
        private IHttpService http_service;

        /// <summary>
        /// Constructor function
        /// </summary>
        /// <param name="service"></param>
        public RegisterStateService(IHttpService http_service) {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add register state
        /// </summary>
        /// <param name="register_state"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public RegisterState addRegisterState(RegisterState register_state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of addRegisterState function

        /// <summary>
        /// Delete register state
        /// </summary>
        /// <param name="register_state"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteRegisterState(RegisterState register_state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteRegisterState function

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public List<RegisterState> getAll(UserSystem user_log)
        {
            return this.http_service.JSONHttpPettitionList<RegisterState>(HttpMethod.GET, this.GetType().Name.ToLower().Replace("service", ""), null);
        }// End of getAll function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="register_state_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public RegisterState getById(int register_state_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public RegisterState getByName(string name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByName function

        /// <summary>
        /// Update register state
        /// </summary>
        /// <param name="register_state"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public RegisterState updateRegisterState(RegisterState register_state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateRegisterState function

    }// End of RegisterStateRepository class
}
