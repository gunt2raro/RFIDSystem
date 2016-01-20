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
    /// Interface TimeReg service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public interface ITimeRegService
    {
        TimeReg getById(int time_reg_id, UserSystem user_log);
        IList<TimeReg> getByRegister(Register register, UserSystem user_log);
        IList<TimeReg> getByDate(DateTime date, UserSystem user_log);
        IList<TimeReg> getByCompetition(Competition competition, UserSystem user_log);
        TimeReg addTimeReg(TimeReg time_reg, UserSystem user_log);
        TimeReg updateTimeReg(TimeReg time_reg, UserSystem user_log);
        bool deleteTimeReg(TimeReg time_reg, UserSystem user_log);

    }// End of ITimeRegService interface
}
