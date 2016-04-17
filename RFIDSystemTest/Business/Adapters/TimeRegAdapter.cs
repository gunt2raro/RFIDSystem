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
    /// <summary>
    /// Time reg adapter
    /// </summary>
    public static class TimeRegAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static TimeRegDTO ObjectToDTO(TimeReg obj)
        {
            return new TimeRegDTO
            {
                register=RegisterAdapter.ObjectToDTO(obj.register),
                timestamp=DataConvert.DateTimeToJsonString(obj.timestamp),
                updated=DataConvert.DateTimeToJsonString(obj.updated)
               
            };
        }// End of ObjectToDTO function

        public static TimeReg DTOToObject(TimeRegDTO dto)
        {
            return new TimeReg
            {
                register = RegisterAdapter.DTOToObject(dto.register),
                timestamp = DataConvert.StringJsonToDateTime(dto.timestamp),
                updated = DataConvert.StringJsonToDateTime(dto.updated)

            };
        }

        public static IList<TimeRegDTO> ObjectsToDTOs(IList<TimeReg> objs)
        {

            IList<TimeRegDTO> list = new List<TimeRegDTO>();

            foreach (TimeReg obj in objs)
            {

                TimeRegDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<TimeReg> DTOsToObjects(IList<TimeRegDTO> dtos)
        {

            IList<TimeReg> list = new List<TimeReg>();

            foreach (TimeRegDTO dto in dtos)
            {

                TimeReg obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

    }// End of TimeRegAdapter class
}
