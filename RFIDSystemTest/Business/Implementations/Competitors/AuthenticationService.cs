using RFIDSystemTest.Business.Interfaces.Competitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;
using RFIDSystemTest.Business.Adapters;
using Newtonsoft.Json;

namespace RFIDSystemTest.Business.Implementations.Competitors
{
    /// <summary>
    /// Implementation Authentication service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public AuthenticationService(IHttpService http_service) {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add authentication
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Authentication addAuthentication(Authentication authentication, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Authentication>(
                HttpMethod.POST,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.SLASH),
                JsonConvert.SerializeObject(
                    AuthenticationAdapter.ObjectToDTO(
                        authentication)));
        }// End of addAuthentication function

        /// <summary>
        /// Delete authentication
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteAuthentication(Authentication authentication, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteAuthentication function

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Authentication> getAll(UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<Authentication>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.EMPTY),
                null);
        }// End of getAll function

        /// <summary>
        /// Get by competitor
        /// </summary>
        /// <param name="competitor"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Authentication getByCompetitor(Competitor competitor, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByCompetitor function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="authentication_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Authentication getById(int authentication_id, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Authentication>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    String.Format(
                        TWords.ONEPARAM,
                        authentication_id)),
                null);
        }// End of getById function

        /// <summary>
        /// Update authentication
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Authentication updateAuthentication(Authentication authentication, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateAuthentication function

    }// End of Authentication Repository class
}
