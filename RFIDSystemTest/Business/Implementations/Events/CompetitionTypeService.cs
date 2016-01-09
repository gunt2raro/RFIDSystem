using RFIDSystemTest.Business.Interfaces.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;

namespace RFIDSystemTest.Business.Implementations.Events
{
    /// <summary>
    /// Implementation Competition Type service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class CompetitionTypeService : ICompetitionTypeService
    {
        /// <summary>
        /// Add competition type
        /// </summary>
        /// <param name="competition_type"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public CompetitionType addCompetitionType(CompetitionType competition_type, UserSystem user_log)
        {
            throw new NotImplementedException();
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
        /// Get by id
        /// </summary>
        /// <param name="competition_type_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public CompetitionType getById(int competition_type_id, UserSystem user_log)
        {
            throw new NotImplementedException();
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
