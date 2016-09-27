using RFIDSystemTest.Business.DTO.Events;
using RFIDSystemTest.Data.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters.Events
{
    /// <summary>
    /// Event type adapter 
    /// </summary>
    public class EventTypeAdapter
    {/// <summary>
     /// Object To Data Transfer Object
     /// </summary>
     /// <param name="competitor"></param>
     /// <returns></returns>
        public static EventTypeDTO ObjectToDTO(EventType event_type_o)
        {
            EventTypeDTO dto = new EventTypeDTO();

            dto.name = event_type_o.name;
            dto.description = event_type_o.description;

            return dto;

        }
        public static EventType DTOToObject(EventTypeDTO event_type_dto)
        {
            EventType obj = new EventType();
            // Fill the variables
            obj.name = event_type_dto.name;
            obj.description = event_type_dto.description;
            // Return this shit
            return obj;
        }// End of Object To DTO function

        public static IList<EventTypeDTO> ObjectsToDTOs(IList<EventType> objs)
        {

            IList<EventTypeDTO> list = new List<EventTypeDTO>();

            foreach (EventType obj in objs)
            {

                EventTypeDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<EventType> DTOsToObjects(IList<EventTypeDTO> dtos)
        {

            IList<EventType> list = new List<EventType>();

            foreach (EventTypeDTO dto in dtos)
            {

                EventType obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }
    }// End of event type adapter class
}
