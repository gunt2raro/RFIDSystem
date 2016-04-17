using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters
{
    /// <summary>
    /// Event Adapter
    /// </summary>
    public static class EventAdapter
    {
        /// <summary>
        /// Object To Data Transfer Object
        /// </summary>
        /// <param name="competitor"></param>
        /// <returns></returns>
        public static EventDTO ObjectToDTO(Event event_o)
        {
            EventDTO dto = new EventDTO();

            dto.date_finish = DataConvert.DateTimeToJsonStringWithTime( event_o.date_finish );
            dto.date_start = DataConvert.DateTimeToJsonStringWithTime( event_o.date_start );
            dto.date_limit = DataConvert.DateTimeToJsonStringWithTime( event_o.date_limit );
            dto.competitors_limit = event_o.competitors_limit;
            dto.description = event_o.description;
            dto.image_url = event_o.image_url;
            dto.name = event_o.name;
            dto.user = event_o.user;
            
            return dto;

        }
        public static Event DTOToObject(EventDTO event_dto)
        {
            Event obj = new Event();

            obj.date_finish = DataConvert.StringJsonToDateTime(event_dto.date_finish);
            obj.date_start = DataConvert.StringJsonToDateTime(event_dto.date_start);
            obj.date_limit = DataConvert.StringJsonToDateTime(event_dto.date_limit);
            obj.competitors_limit = event_dto.competitors_limit;
            obj.description = event_dto.description;
            obj.image_url = event_dto.image_url;
            obj.name = event_dto.name;
            obj.user = event_dto.user;

            return obj;

        }// End of Object To DTO function

        public static IList<EventDTO> ObjectsToDTOs(IList<Event> objs)
        {

            IList<EventDTO> list = new List<EventDTO>();

            foreach (Event obj in objs)
            {

                EventDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<Event> DTOsToObjects(IList<EventDTO> dtos)
        {

            IList<Event> list = new List<Event>();

            foreach (EventDTO dto in dtos)
            {

                Event obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

    }// End of Event Adapter class
}
