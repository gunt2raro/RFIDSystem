using RFIDSystemTest.Business.Interfaces.Competitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;
using Newtonsoft.Json;
using RFIDSystemTest.Business.Adapters;

namespace RFIDSystemTest.Business.Implementations.Competitors
{
    /// <summary>
    /// Implementation Register service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class RegisterService : IRegisterService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public RegisterService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add register
        /// </summary>
        /// <param name="register"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register addRegister(Register register, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Register>(
                   HttpMethod.POST,
                   GetType().Name.ToLower().Replace(
                       TWords.SERVICE,
                       TWords.SLASH),
                   JsonConvert.SerializeObject(
                       RegisterAdapter.ObjectToDTO(
                           register)));
        }// End of addRegister function

        /// <summary>
        /// Delete register
        /// </summary>
        /// <param name="register"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteRegister(Register register, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteRegister function

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Register> getAll(UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getAll function

        /// <summary>
        /// Get by category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register getByCategory(Category category, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByCategory function

        /// <summary>
        /// Get by competitionon number
        /// </summary>
        /// <param name="competitor_num"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register getByCompetitionNum(int competitor_num, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByCompetitionNum function

        /// <summary>
        /// Get by competitor
        /// </summary>
        /// <param name="competitor"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register getByCompetitor(Competitor competitor, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByCompetitor function

        /// <summary>
        /// Get by date
        /// </summary>
        /// <param name="date"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register getByDate(DateTime date, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByDate function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="register_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register getById(int register_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register getByUser(UserSystem user, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByUser function

        /// <summary>
        /// Get competition number
        /// </summary>
        /// <param name="competition"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public int getCompetitorNum(int competition_id, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<int>(
                HttpMethod.GET, 
                string.Format( 
                    "register/competitornum/{0}", 
                    competition_id ), 
                null );
        }// End of getCompetitionNum function

        /// <summary>
        /// Get registers by competition
        /// </summary>
        /// <param name="competition"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Register> getRegistersByCompetition(Competition competition, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getRegistersByCompetition function

        /// <summary>
        /// Get registers by competitor number
        /// </summary>
        /// <param name="competitor_num"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Register> getRegistersByCompetitorNum(int competitor_num, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getRegistersByCompetitorNum function

        /// <summary>
        /// Update register
        /// </summary>
        /// <param name="register"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Register updateRegister(Register register, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateRegister function

    }// End of Register Repository class
}
