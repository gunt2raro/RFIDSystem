using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters.Users
{
    public class UserSystemAdapter
    {
        public static UserSystemDTO ObjectToDTO(UserSystem obj)
        {
            return new UserSystemDTO
            {
                password = obj.password,
                rol = obj.rol,
                user = obj.user,
                user_name=obj.user_name,
                birth_date = DataConvert.DateTimeToJsonString(obj.birth_date),
          

            };

        }

        public static UserSystem DTOToObject(UserSystemDTO dto)
        {
            return new UserSystem
            {
                password = dto.password,
                rol = dto.rol,
                user = dto.user,
                user_name = dto.user_name,
                birth_date = DataConvert.StringJsonToDateTime(dto.birth_date),
            };

        }
        public static IList<UserSystemDTO> ObjectsToDTOs(IList<UserSystem> objs)
        {

            IList<UserSystemDTO> list = new List<UserSystemDTO>();

            foreach (UserSystem obj in objs)
            {

                UserSystemDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<UserSystem> DTOsToObjects(IList<UserSystemDTO> dtos)
        {

            IList<UserSystem> list = new List<UserSystem>();

            foreach (UserSystemDTO dto in dtos)
            {

                UserSystem obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }
    }
}
