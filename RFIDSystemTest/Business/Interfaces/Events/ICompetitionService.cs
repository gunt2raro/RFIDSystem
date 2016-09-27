using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        IList<Competition> getAll( UserSystem user_log );
        Competition getById(int competition_id, UserSystem user_log);
        Competition getByName(string name, UserSystem user_log);
        Competition getByDate(DateTime date, UserSystem user_log);
        IList<Category> getCategoriesById(int competition_id, UserSystem user_log);
        IList<Competitor> getCompetitorsById(int competition_id, UserSystem user_log);
        IList<Competition> getCompetitionsByEvent(Event event_o, UserSystem user_log);
        Competition addCompetition(Competition competition, UserSystem user_log);
        Competition updateCompetition(Competition competition, UserSystem user_log);
        bool deleteCompetition(Competition competition, UserSystem user_log);
        Competition ImageToCompetition(Competition competition, Image img, UserSystem user_log);
    }//End of ICompetitionService interface
}
