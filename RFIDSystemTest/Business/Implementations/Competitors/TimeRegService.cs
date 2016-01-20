using RFIDSystemTest.Business.Interfaces.Competitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Business.Implementations.Competitors
{
    /// <summary>
    /// Implementation Time Reg service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class TimeRegService : ITimeRegService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public TimeRegService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add time register
        /// </summary>
        /// <param name="time_reg"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public TimeReg addTimeReg(TimeReg time_reg, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of addTimeReg function

        /// <summary>
        /// Delete time register
        /// </summary>
        /// <param name="time_reg"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteTimeReg(TimeReg time_reg, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteTimeReg function

        /// <summary>
        /// Get by competition
        /// </summary>
        /// <param name="competition"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<TimeReg> getByCompetition(Competition competition, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByCompetition function

        /// <summary>
        /// Get by data
        /// </summary>
        /// <param name="date"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<TimeReg> getByDate(DateTime date, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByDate function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="time_reg_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public TimeReg getById(int time_reg_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by register
        /// </summary>
        /// <param name="register"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<TimeReg> getByRegister(Register register, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByRegister function

        /// <summary>
        /// Update time register
        /// </summary>
        /// <param name="time_reg"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public TimeReg updateTimeReg(TimeReg time_reg, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateTimeReg function

    }// End of Time Reg Repository class
}
