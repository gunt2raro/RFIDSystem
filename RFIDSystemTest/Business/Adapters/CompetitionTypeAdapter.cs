using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters
{
    /// <summary>
    /// Competition type adapter
    /// </summary>
    public static class CompetitionTypeAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static CompetitionTypeDTO ObjectToDTO(CompetitionType authentication)
        {
            CompetitionTypeDTO dto = new CompetitionTypeDTO();
            return dto;
        }// End of ObjectToDTO function

    }// End of CompetitionTypeAdapter class
}
