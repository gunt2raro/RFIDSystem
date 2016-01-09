using RFIDSystemTest.Data.Competitors;
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
    /// Interface competition service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public interface ICompetitionService
    {
        Competition getById(int competition_id, UserSystem user_log);
        Competition getByName(string name, UserSystem user_log);
        Competition getByDate(DateTime date, UserSystem user_log);
        List<Category> getCategoriesById(int competition_id, UserSystem user_log);
        List<Competitor> getCompetitorsById(int competition_id, UserSystem user_log);
        Competition addCompetition(Competition competition, UserSystem user_log);
        Competition updateCompetition(Competition competition, UserSystem user_log);
        bool deleteCompetition(Competition competition, UserSystem user_log);

    }//End of ICompetitionService interface
}
