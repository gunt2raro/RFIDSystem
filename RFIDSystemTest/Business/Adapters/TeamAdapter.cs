using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters
{
    public static class TeamAdapter
    {
        public static Team DTOToObject(TeamDTO dto) {

            return new Team
            {
                name = dto.name,
                description = dto.description,
                city = dto.city,
                country = dto.country,
                state = dto.state,
                timestamp = DataConvert.StringJsonToDateTime(dto.timestamp),
                updated = DataConvert.StringJsonToDateTime(dto.updated)  
            };

            
        }

        public static TeamDTO ObjectToDTO(Team obj)
        {

            return new TeamDTO
            {
                name = obj.name,
                description = obj.description,
                city = obj.city,
                country = obj.country,
                state = obj.state,
                timestamp = DataConvert.DateTimeToJsonString(obj.timestamp),
                updated = DataConvert.DateTimeToJsonString(obj.updated)
            };
        }

        public static IList<TeamDTO> ObjectsToDTOs(IList<Team> objs)
        {

            IList<TeamDTO> list = new List<TeamDTO>();

            foreach (Team obj in objs){

               TeamDTO dto= ObjectToDTO(obj);
               list.Add(dto);
            }

            return list;
        }

        public static IList<Team> DTOsToObjects (IList<TeamDTO> dtos)
        {

            IList<Team> list = new List<Team>();

            foreach (TeamDTO dto in dtos)
            {

                Team obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }
    }
}
