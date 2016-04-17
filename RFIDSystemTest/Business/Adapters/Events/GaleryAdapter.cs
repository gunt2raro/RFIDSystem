using RFIDSystemTest.Business.DTO.Events;
using RFIDSystemTest.Data.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters.Events
{
    public static class GaleryAdapter
    {
        public static Galery DTOToObject(GaleryDTO dto)
        {
            return new Galery
            {
                _event=dto._event,
                image_url=dto.image_url
            };
        }

        public static GaleryDTO ObjectToDTO(Galery obj)
        {
            return new GaleryDTO {

                _event=obj._event,
                image_url=obj.image_url
            };
        }

        public static IList<Galery> ObjectsToDTOs(IList<GaleryDTO> dtos)
        {
            IList<Galery> list = new List<Galery>();

            foreach (GaleryDTO dto in dtos) {
                Galery obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

        public static IList<GaleryDTO> DTOsToObjects(IList<Galery> dtos)
        {
            IList<GaleryDTO> list = new List<GaleryDTO>();

            foreach (Galery dto in dtos)
            {
                GaleryDTO obj = ObjectToDTO(dto);
                list.Add(obj);
            }

            return list;

        }
    }
}
