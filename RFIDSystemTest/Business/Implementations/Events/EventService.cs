using RFIDSystemTest.Business.Interfaces.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;
using Newtonsoft.Json;
using RFIDSystemTest.Business.Adapters;
using System.Drawing;

namespace RFIDSystemTest.Business.Implementations.Events
{
    /// <summary>
    /// Implementation Event service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class EventService : IEventService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="http_service"></param>
        public EventService( IHttpService http_service ) {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add event
        /// </summary>
        /// <param name="event_o"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Event addEvent(Event event_o, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Event>(
                HttpMethod.POST, 
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE, 
                    TWords.SLASH), 
                JsonConvert.SerializeObject(
                    EventAdapter.ObjectToDTO(
                        event_o)));
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
        /// Get all
        /// </summary>
        /// <param name="user_log"> for authentication stuff </param>
        /// <returns></returns>
        public IList<Event> getAll(UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<Event>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.EMPTY),
                null);
        }// End of getAll function

        /// <summary>
        /// Get by data
        /// </summary>
        /// <param name="date"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Event> getByDate(DateTime date, UserSystem user_log)
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
            return http_service.JSONHttpPettitionObject<Event>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    String.Format(
                        TWords.ONEPARAM,
                        event_id)),
                null);
        }// End of getById function

        /// <summary>
        /// Get competition by id
        /// </summary>
        /// <param name="event_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Competition> getCompetitionsById(int event_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getCompetitionsById function

        /// <summary>
        /// Image to event
        /// Sends the image to the server and shit
        /// </summary>
        /// <param name="event_o"></param>
        /// <param name="img"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Event ImageToEvent(Event event_o, Image img, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Event>( 
                HttpMethod.PUT, 
                string.Format( 
                    "event/image/{0}", 
                    event_o.id ), JsonConvert.SerializeObject(DataConvert.ImageToByte(img)));
        }// End of ImageToEvent function

        /// <summary>
        /// Update event
        /// </summary>
        /// <param name="event_o"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Event updateEvent(Event event_o, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Event>(
                   HttpMethod.PUT,
                   GetType().Name.ToLower().Replace(
                       TWords.SERVICE,
                       string.Format(
                           TWords.ONEPARAM,
                           event_o.id)),
                   JsonConvert.SerializeObject(
                       EventAdapter.ObjectToDTO(event_o)));
        }// End of updateEvent function

        
    }// End of EventRepository class
}
