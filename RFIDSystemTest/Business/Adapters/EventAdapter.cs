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
            
            return dto;

        }// End of Object To DTO function

    }// End of Event Adapter class
}
