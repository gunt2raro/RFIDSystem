using RFIDSystemTest.Business.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Business.Implementations.Users
{
    /// <summary>
    /// Implementation Rol service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public class RolService : IRolService
    {
        private IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="http_service"></param>
        public RolService( IHttpService http_service ) {
            this.http_service = http_service;
        }// End of Constructor function
        
        /// <summary>
        /// Add rol
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Rol addRol(Rol rol, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of addRol function

        /// <summary>
        /// Delete rol
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="uesr_log"></param>
        /// <returns></returns>
        public bool deleteRol(Rol rol, UserSystem uesr_log)
        {
            throw new NotImplementedException();
        }// End of deleteRol function

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Rol> getAll(UserSystem user_log)
        {
            return this.http_service.JSONHttpPettitionList<Rol>( HttpMethod.GET, this.GetType().Name.ToLower().Replace( "service", "" ), null );
        }// End of getAll function 

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="rol_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Rol getById(int rol_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Rol getByName(string name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByName function
        
        /// <summary>
        /// Get by value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Rol> getByValue(int value, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByValue function

        /// <summary>
        /// Update rol
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Rol updateRol(Rol rol, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateRol function

    }// End of RolRepository class
}
