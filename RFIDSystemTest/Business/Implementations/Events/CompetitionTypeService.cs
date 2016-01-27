using RFIDSystemTest.Business.Interfaces.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;
using Newtonsoft.Json;
using RFIDSystemTest.Business.Adapters;

namespace RFIDSystemTest.Business.Implementations.Events
{
    /// <summary>
    /// Implementation Competition Type service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class CompetitionTypeService : ICompetitionTypeService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public CompetitionTypeService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add competition type
        /// </summary>
        /// <param name="competition_type"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public CompetitionType addCompetitionType(CompetitionType competition_type, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<CompetitionType>(
                HttpMethod.POST,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.SLASH),
                JsonConvert.SerializeObject(
                    CompetitionTypeAdapter.ObjectToDTO(
                        competition_type)));
        }// End of addCompetitionType function

        /// <summary>
        /// Delete competition type
        /// </summary>
        /// <param name="competition_type"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteCompetitionType(CompetitionType competition_type, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteCompetitionType function

        /// <summary>
        /// Get all
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<CompetitionType> getAll(UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<CompetitionType>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.EMPTY),
                null);
        }// End of getAll function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="competition_type_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public CompetitionType getById(int competition_type_id, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<CompetitionType>(
                 HttpMethod.GET,
                 GetType().Name.ToLower().Replace(
                     TWords.SERVICE,
                     String.Format(
                         TWords.ONEPARAM,
                         competition_type_id)),
                 null);
        }// End of getById function

        /// <summary>
        /// Get by name
        /// </summary>
        /// <param name="comeptition_name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public CompetitionType getByName(int comeptition_name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByName function

        /// <summary>
        /// Update competition type
        /// </summary>
        /// <param name="competition_type"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public CompetitionType updateCompetitionType(CompetitionType competition_type, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateCompetitionType function

    }// End of CompetitionTypeRepository class
}
