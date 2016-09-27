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
    /// Register adapter
    /// </summary>
    public static class RegisterAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static RegisterDTO ObjectToDTO(Register register)
        {
            RegisterDTO dto = new RegisterDTO();

            dto.competitor = register.competitor;
            dto.competition = register.competition;
            dto.competitor_num = register.competitor_num;
            dto.category = register.category;
            dto.kit_state = register.kit_state;
            dto.register_state = register.register_state;
            dto.team = register.team;
            dto.user = register.user;
            
            dto.timestamp = DataConvert.DateTimeToJsonString(register.timestamp);
            dto.timestamp = DataConvert.DateTimeToJsonString(register.timestamp);

            return dto;
        }// End of ObjectToDTO function

        /// <summary>
        /// DTO To object conversion
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static Register DTOToObject(RegisterDTO dto)
        {
            Register obj = new Register();

            obj.competitor = dto.competitor;
            obj.competition = dto.competition;
            obj.competitor_num = dto.competitor_num;
            obj.category = dto.category;
            obj.kit_state = dto.kit_state;
            obj.register_state = dto.register_state;
            obj.team = dto.team;
            obj.user = dto.user;

            obj.timestamp = DataConvert.StringJsonToDateTime(dto.timestamp);
            obj.timestamp = DataConvert.StringJsonToDateTime(dto.timestamp);
            return obj;
        }// End of DTOToIbject function

        /// <summary>
        /// Objects to DTO list
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        public static IList<RegisterDTO> ObjectsToDTOs(IList<Register> objs)
        {

            IList<RegisterDTO> list = new List<RegisterDTO>();

            foreach (Register obj in objs)
            {

                RegisterDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<Register> DTOsToObjects(IList<RegisterDTO> dtos)
        {

            IList<Register> list = new List<Register>();

            foreach (RegisterDTO dto in dtos)
            {

                Register obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

    }// End of RegisterAdapter classs
}
