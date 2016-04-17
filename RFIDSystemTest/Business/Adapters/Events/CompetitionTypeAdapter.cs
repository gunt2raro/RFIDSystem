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
    /// Competition type adapter
    /// </summary>
    public static class CompetitionTypeAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static CompetitionTypeDTO ObjectToDTO(CompetitionType obj)
        {
            return new CompetitionTypeDTO
            {
                name = obj.name,
                description = obj.description,
                timestamp = DataConvert.DateTimeToJsonString(obj.timestamp),
                updated = DataConvert.DateTimeToJsonString(obj.updated)
            };
        }

        public static CompetitionType DTOToObject(CompetitionTypeDTO dto)
        {
            return new CompetitionType
            {
                name = dto.name,
                description = dto.description,
                timestamp = DataConvert.StringJsonToDateTime(dto.timestamp),
                updated = DataConvert.StringJsonToDateTime(dto.updated)
            };
        }

        public static IList<CompetitionTypeDTO> ObjectsToDTOs(IList<CompetitionType> objs)
        {

            IList<CompetitionTypeDTO> list = new List<CompetitionTypeDTO>();

            foreach (CompetitionType obj in objs)
            {

                CompetitionTypeDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<CompetitionType> DTOsToObjects(IList<CompetitionTypeDTO> dtos)
        {

            IList<CompetitionType> list = new List<CompetitionType>();

            foreach (CompetitionTypeDTO dto in dtos)
            {

                CompetitionType obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

    }// End of CompetitionTypeAdapter class
}
