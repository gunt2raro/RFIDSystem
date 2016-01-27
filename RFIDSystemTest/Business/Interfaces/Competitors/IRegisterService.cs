using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Competitors
{
    /// <summary>
    /// Interface Register service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public interface IRegisterService
    {
        IList<Register> getAll( UserSystem user_log );
        Register getById(int register_id, UserSystem user_log);
        Register getByCompetitor(Competitor competitor, UserSystem user_log);
        Register getByCategory(Category category, UserSystem user_log);
        Register getByCompetitionNum(int competitor_num, UserSystem user_log);
        Register getByDate(DateTime date, UserSystem user_log);
        Register getByUser(UserSystem user, UserSystem user_log);
        IList<Register> getRegistersByCompetition(Competition competition, UserSystem user_log);
        IList<Register> getRegistersByCompetitorNum(int competitor_num, UserSystem user_log);
        Register addRegister(Register register, UserSystem user_log);
        Register updateRegister(Register register, UserSystem user_log);
        bool deleteRegister(Register register, UserSystem user_log);

    }//End of IRegisterService interface
}
