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
    /// Competition Adapter
    /// </summary>
    public static class CompetitionAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static CompetitionDTO ObjectToDTO(Competition competition)
        {
            CompetitionDTO dto = new CompetitionDTO();

            dto.name = competition.name;
            dto.description = competition.description;
            dto.date_start = DataConvert.DateTimeToJsonStringWithTime(competition.date_start);
            dto.date_finish = DataConvert.DateTimeToJsonStringWithTime(competition.date_finish);
            dto.competition_event = competition.competition_event;
            dto.competition_type = competition.competition_type;
            dto.competitors_limit = competition.competitors_limit;
            dto.categories = competition.categories;
            dto.image_url = "";

            return dto;
        }// End of ObjectToDTO function

    }// End of Competitor Adapter class
}
