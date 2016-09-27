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
using RFIDSystemTest.Business.Adapters;
using Newtonsoft.Json;
using System.Drawing;

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
            return http_service.JSONHttpPettitionObject<Competition>(
                HttpMethod.POST,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.SLASH),
                JsonConvert.SerializeObject(
                    CompetitionAdapter.ObjectToDTO(
                        competition)));
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
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competition> getAll(UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<Competition>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.EMPTY),
                null);
        }// End of getAll function

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
            return http_service.JSONHttpPettitionObject<Competition>(
                   HttpMethod.GET,
                   GetType().Name.ToLower().Replace(
                       TWords.SERVICE,
                       String.Format(
                           TWords.ONEPARAM,
                           competition_id)),
                   null);
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
            return http_service.JSONHttpPettitionList<Category>(
                HttpMethod.GET,
                string.Format(
                    "competition/categories/?competition_id={0}", competition_id),
                null);
        }// End of getCategoriesById function

        /// <summary>
        /// Get competitions by event
        /// </summary>
        /// <param name="event_o"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competition> getCompetitionsByEvent(Event event_o, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<Competition>( 
                HttpMethod.GET, 
                string.Format(
                    "competition/byevent/?event_id={0}", event_o.id), 
                null);
        }// End of getCompetitionsByEvent function

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
        /// Upload the image of the route to the db
        /// </summary>
        /// <param name="competition"></param>
        /// <param name="img"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competition ImageToCompetition(Competition competition, Image img, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Competition>(
                HttpMethod.PUT,
                string.Format(
                    "competition/image/{0}",
                    competition.id), JsonConvert.SerializeObject(DataConvert.ImageToByte(img)));
        }// End of ImageToCompetition function

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
