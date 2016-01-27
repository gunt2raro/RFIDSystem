using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Events
{
    /// <summary>
    /// Interface CompetitionType  service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public interface ICompetitionTypeService
    {
        IList<CompetitionType> getAll( UserSystem user_log);
        CompetitionType getById(int competition_type_id, UserSystem user_log);
        CompetitionType getByName(int comeptition_name, UserSystem user_log);
        CompetitionType addCompetitionType(CompetitionType competition_type, UserSystem user_log);
        CompetitionType updateCompetitionType(CompetitionType competition_type, UserSystem user_log);
        bool deleteCompetitionType(CompetitionType competition_type, UserSystem user_log);

    }// End of ICompetitionTypeService interface
}
