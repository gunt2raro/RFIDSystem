using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.States;
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
            KitStateDTO dto = new KitStateDTO();
            return dto;
        }// End of ObjectToDTO function

    }// End of KitStateAdapter class
}
