using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Competitors
{
    /// <summary>
    /// Interface Competitor service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public interface ICompetitorService
    {
        IList<Competitor> getAll( UserSystem user_log );
        Competitor getById(int competitor_id, UserSystem user_log);
        Competitor getByName(string name, UserSystem user_log);
        Competitor getBySecondName(string second_name, UserSystem user_log);
        IList<Competitor> getByCountry(string country, UserSystem user_log);
        IList<Competitor> getByState(string state, UserSystem user_log);
        IList<Competitor> getByCity(string city, UserSystem user_log);
        IList<Competitor> getByZipCode(int zip_code, UserSystem user_log);
        IList<Competitor> getByUser(UserSystem user, UserSystem user_log);
        IList<Competitor> getByBirthDate(DateTime birth_date, UserSystem user_log);
        Competitor addCompetitor(Competitor competitor, UserSystem user_log);
        Competitor updateCompetitor(Competitor competitor, UserSystem user_log);
        bool deleteCompetitor(Competitor competitor, UserSystem user_log);

    }// End of ICompetitor Service interface
}
