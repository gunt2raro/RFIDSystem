using RFIDSystemTest.Business.DTO.Users;
using RFIDSystemTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters.Users
{
    public static class UserAdapter
    {
        public static UserDTO ObjectToDTO(User obj)
        {
            return new UserDTO
            {
              email=obj.email,
              password=obj.password,
              pk=obj.pk,
              username=obj.username
            };

        }

        public static User DTOToObject(UserDTO dto)
        {
            return new User
            {
                email = dto.email,
                password = dto.password,
                pk = dto.pk,
                username = dto.username

            };

        }
        public static IList<UserDTO> ObjectsToDTOs(IList<User> objs)
        {

            IList<UserDTO> list = new List<UserDTO>();

            foreach (User obj in objs)
            {

                UserDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<User> DTOsToObjects(IList<UserDTO> dtos)
        {

            IList<User> list = new List<User>();

            foreach (UserDTO dto in dtos)
            {

                User obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }
    }
}
