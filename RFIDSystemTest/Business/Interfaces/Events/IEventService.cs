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
    /// Interface Event service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public interface IEventService
    {
        Event getById(int event_id, UserSystem user_log);
        List<Event> getByDate(DateTime date, UserSystem user_log);
        List<Competition> getCompetitionsById(int event_id, UserSystem user_log);
        Event addEvent(Event event_o, UserSystem user_log);
        Event updateEvent(Event event_o, UserSystem user_log);
        bool deleteEvent(Event event_o, UserSystem user_log);

    }// End of IEventService interface
}
