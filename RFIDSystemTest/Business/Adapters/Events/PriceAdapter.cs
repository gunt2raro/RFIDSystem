using RFIDSystemTest.Business.DTO.Events;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters.Events
{
    public static class PriceAdapter
    {
        public static Price DTOToObject(PriceDTO dto)
        {
            return new Price
            {
                _event = dto._event,
                description= dto.description,
                name=dto.name,
                image_url = dto.image_url,
                timestamp=DataConvert.StringJsonToDateTime(dto.timestamp),
                updated = DataConvert.StringJsonToDateTime(dto.updated)

            };
        }

        public static PriceDTO ObjectToDTO(Price obj)
        {
            return new PriceDTO
            {

                _event = obj._event,
                description = obj.description,
                name = obj.name,
                image_url = obj.image_url,
                timestamp = DataConvert.DateTimeToJsonString(obj.timestamp),
                updated = DataConvert.DateTimeToJsonString(obj.updated)
            };
        }

        public static IList<Price> ObjectsToDTOs(IList<PriceDTO> dtos)
        {
            IList<Price> list = new List<Price>();

            foreach (PriceDTO dto in dtos)
            {
                Price obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

        public static IList<PriceDTO> DTOsToObjects(IList<Price> dtos)
        {
            IList<PriceDTO> list = new List<PriceDTO>();

            foreach (Price dto in dtos)
            {
                PriceDTO obj = ObjectToDTO(dto);
                list.Add(obj);
            }

            return list;

        }
    }
}
