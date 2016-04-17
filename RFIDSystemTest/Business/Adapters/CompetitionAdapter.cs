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
            dto.image_url = competition.image_url;
            dto.user = competition.user;

            dto.timestamp = DataConvert.DateTimeToJsonString(competition.timestamp);
            dto.updated = DataConvert.DateTimeToJsonString(competition.updated);


            return dto;
        }// End of ObjectToDTO function

        public static Competition DTOToObject(CompetitionDTO dto)
        {
            return new Competition
            {
                name = dto.name,
                description = dto.description,
                date_start = DataConvert.StringJsonToDateTime(dto.date_start),
                date_finish = DataConvert.StringJsonToDateTime(dto.date_finish),
                competition_event = dto.competition_event,
                competition_type = dto.competition_type,
                competitors_limit = dto.competitors_limit,
                categories = dto.categories,
                image_url = dto.image_url,
                user = dto.user,

                timestamp = DataConvert.StringJsonToDateTime(dto.timestamp),
                updated = DataConvert.StringJsonToDateTime(dto.updated),
            };

        }

        public static IList<CompetitionDTO> ObjectsToDTOs(IList<Competition> objs)
        {

            IList<CompetitionDTO> list = new List<CompetitionDTO>();

            foreach (Competition obj in objs)
            {

                CompetitionDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<Competition> DTOsToObjects(IList<CompetitionDTO> dtos)
        {

            IList<Competition> list = new List<Competition>();

            foreach (CompetitionDTO dto in dtos)
            {

                Competition obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

    }// End of Competitor Adapter class
}
