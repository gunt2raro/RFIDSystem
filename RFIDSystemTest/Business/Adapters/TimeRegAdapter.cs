using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.Competitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters
{
    /// <summary>
    /// Time reg adapter
    /// </summary>
    public static class TimeRegAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static TimeRegDTO ObjectToDTO(TimeReg authentication)
        {
            TimeRegDTO dto = new TimeRegDTO();
            return dto;
        }// End of ObjectToDTO function

    }// End of TimeRegAdapter class
}
