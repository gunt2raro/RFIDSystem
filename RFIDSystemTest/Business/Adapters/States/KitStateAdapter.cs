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
    /// Kit state adapter
    /// </summary>
    public static class KitStateAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static KitStateDTO ObjectToDTO(KitState kit_state)
        {
            return new KitStateDTO
            {
                description = kit_state.description,
                value = kit_state.value,
                timestamp = DataConvert.DateTimeToJsonString(kit_state.timestamp),
                updated = DataConvert.DateTimeToJsonString(kit_state.updated)

            };

        }

        public static KitState DTOToObject(KitStateDTO kit_state)
        {
            return new KitState
            {
                description = kit_state.description,
                value = kit_state.value,
                timestamp = DataConvert.StringJsonToDateTime(kit_state.timestamp),
                updated = DataConvert.StringJsonToDateTime(kit_state.updated)

            };

        }
        public static IList<KitStateDTO> ObjectsToDTOs(IList<KitState> objs)
        {

            IList<KitStateDTO> list = new List<KitStateDTO>();

            foreach (KitState obj in objs)
            {

                KitStateDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<KitState> DTOsToObjects(IList<KitStateDTO> dtos)
        {

            IList<KitState> list = new List<KitState>();

            foreach (KitStateDTO dto in dtos)
            {

                KitState obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }


    }// End of KitStateAdapter class
}
