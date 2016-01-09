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
    /// Implementation Event service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class EventService : IEventService
    {
        /// <summary>
        /// Add event
        /// </summary>
        /// <param name="event_o"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Event addEvent(Event event_o, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of addEvent function

        /// <summary>
        /// Delete event
        /// </summary>
        /// <param name="event_o"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteEvent(Event event_o, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteEvent function

        /// <summary>
        /// Get by data
        /// </summary>
        /// <param name="date"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public List<Event> getByDate(DateTime date, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByDate function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="event_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Event getById(int event_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get competition by id
        /// </summary>
        /// <param name="event_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public List<Competition> getCompetitionsById(int event_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getCompetitionsById function

        /// <summary>
        /// Update event
        /// </summary>
        /// <param name="event_o"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Event updateEvent(Event event_o, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateEvent function

    }// End of EventRepository class
}
