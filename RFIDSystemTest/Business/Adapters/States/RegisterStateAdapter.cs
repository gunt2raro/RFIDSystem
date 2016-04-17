using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.States;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters
{
    /// <summary>
    /// Register state adapter
    /// </summary>
    public static class RegisterStateAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static RegisterStateDTO ObjectToDTO(RegisterState obj)
        {
            return new RegisterStateDTO
            {
                description=obj.description,
                value=obj.value,
                timestamp=DataConvert.DateTimeToJsonString(obj.timestamp),
                updated=DataConvert.DateTimeToJsonString(obj.updated)
            };
        }// End of ObjectToDTO function

        public static RegisterState DTOToObject (RegisterStateDTO dto)
        {
            return new RegisterState
            {
                description = dto.description,
                value = dto.value,
                timestamp = DataConvert.StringJsonToDateTime(dto.timestamp),
                updated = DataConvert.StringJsonToDateTime(dto.updated)
            };
        }

        public static IList<RegisterStateDTO> ObjectsToDTOs(IList<RegisterState> objs)
        {

            IList<RegisterStateDTO> list = new List<RegisterStateDTO>();

            foreach (RegisterState obj in objs)
            {

                RegisterStateDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<RegisterState> DTOsToObjects(IList<RegisterStateDTO> dtos)
        {

            IList<RegisterState> list = new List<RegisterState>();

            foreach (RegisterStateDTO dto in dtos)
            {

                RegisterState obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }
    }// End of RegisterStateAdapter class
}
