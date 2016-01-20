using RFIDSystemTest.Business.Interfaces.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Business.Implementations.Events
{
    /// <summary>
    /// Implementation Competitor service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class CompetitionService : ICompetitionService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public CompetitionService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add competition
        /// </summary>
        /// <param name="competition"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competition addCompetition(Competition competition, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of addCompetition function

        /// <summary>
        /// Delete competition
        /// </summary>
        /// <param name="competition"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteCompetition(Competition competition, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteCompetition function

        /// <summary>
        /// Get by date
        /// </summary>
        /// <param name="date"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competition getByDate(DateTime date, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByDate function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="competition_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competition getById(int competition_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competition getByName(string name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByName function

        /// <summary>
        /// Get categories by id
        /// </summary>
        /// <param name="competition_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Category> getCategoriesById(int competition_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getCategoriesById function

        /// <summary>
        /// Get competitors by id
        /// </summary>
        /// <param name="competition_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getCompetitorsById(int competition_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getCompetitorsById function

        /// <summary>
        /// Update competition
        /// </summary>
        /// <param name="competition"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competition updateCompetition(Competition competition, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateCompetition function

    }// End of CompetitionRepository class
}
