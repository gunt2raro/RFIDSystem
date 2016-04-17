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
    public static class RolAdapter
    {
        public static RolDTO ObjectToDTO(Rol obj)
        {
            return new RolDTO
            {
                description = obj.description,
                value = obj.value,
                name=obj.name,
                
                timestamp = DataConvert.DateTimeToJsonString(obj.timestamp),
                updated = DataConvert.DateTimeToJsonString(obj.updated)

            };

        }

        public static Rol DTOToObject(RolDTO dto)
        {
            return new Rol
            {
                description = dto.description,
                value = dto.value,
                name= dto.name,
                timestamp = DataConvert.StringJsonToDateTime(dto.timestamp),
                updated = DataConvert.StringJsonToDateTime(dto.updated)

            };

        }
        public static IList<RolDTO> ObjectsToDTOs(IList<Rol> objs)
        {

            IList<RolDTO> list = new List<RolDTO>();

            foreach (Rol obj in objs)
            {

                RolDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<Rol> DTOsToObjects(IList<RolDTO> dtos)
        {

            IList<Rol> list = new List<Rol>();

            foreach (RolDTO dto in dtos)
            {

                Rol obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }
    }
}
