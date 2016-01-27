using RFIDSystemTest.Business.Interfaces.Competitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;
using Newtonsoft.Json;
using RFIDSystemTest.Business.Adapters;

namespace RFIDSystemTest.Business.Implementations.Competitors
{
    /// <summary>
    /// Implementation Competitor service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class CompetitorService : ICompetitorService
    {
        private IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="http_service"></param>
        public CompetitorService( IHttpService http_service ) {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add competitor
        /// </summary>
        /// <param name="competitor"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competitor addCompetitor(Competitor competitor, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Competitor>( 
                HttpMethod.POST, 
                GetType().Name.ToLower().Replace( 
                    TWords.SERVICE, 
                    TWords.SLASH ), 
                JsonConvert.SerializeObject( 
                    CompetitorAdapter.ObjectToDTO( 
                        competitor ) ) );
        }// End of addCompetitor function

        /// <summary>
        /// Delete competitor
        /// </summary>
        /// <param name="competitor"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteCompetitor(Competitor competitor, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Competitor>(
                HttpMethod.DELETE,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    String.Format(
                        TWords.ONEPARAM,
                        competitor.id)),
                null) == null ? true : false;
        }// End of deleteCompetitor function

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getAll(UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<Competitor>( 
                HttpMethod.GET, 
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE, 
                    TWords.EMPTY), 
                null );
        }// End of getAll function

        /// <summary>
        /// Get by birth date
        /// </summary>
        /// <param name="birth_date"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getByBirthDate(DateTime birth_date, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByBirthDate function

        /// <summary>
        /// Get by city
        /// </summary>
        /// <param name="city"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getByCity(string city, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByCity function

        /// <summary>
        /// Get by country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getByCountry(string country, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByCountry function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="competitor_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competitor getById(int competitor_id, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Competitor>(
                HttpMethod.GET, 
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE, 
                    String.Format( 
                        TWords.ONEPARAM, 
                        competitor_id ) ), 
                null );
        }// End of getById function

        /// <summary>
        /// Get by name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competitor getByName(string name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByName function

        /// <summary>
        /// Get by second name
        /// </summary>
        /// <param name="second_name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competitor getBySecondName(string second_name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getBySecondName function

        /// <summary>
        /// Get by state
        /// </summary>
        /// <param name="state"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getByState(string state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByState function

        /// <summary>
        /// Get by user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getByUser(UserSystem user, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByUser function

        /// <summary>
        /// Get by zip code
        /// </summary>
        /// <param name="zip_code"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competitor> getByZipCode(int zip_code, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByZipCode function

        /// <summary>
        /// Update competitor
        /// </summary>
        /// <param name="competitor"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Competitor updateCompetitor(Competitor competitor, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Competitor>(
                HttpMethod.PUT, 
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE, 
                    string.Format(
                        TWords.ONEPARAM, 
                        competitor.id)),
                JsonConvert.SerializeObject( 
                    CompetitorAdapter.ObjectToDTO( competitor ) ) );
        }// End of updateCompetitor function

    }// End of Competitor Repository class
}
