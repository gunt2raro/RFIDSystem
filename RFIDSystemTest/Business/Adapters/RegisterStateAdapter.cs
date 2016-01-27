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
    /// Register state adapter
    /// </summary>
    public static class RegisterStateAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static RegisterStateDTO ObjectToDTO(RegisterState authentication)
        {
            RegisterStateDTO dto = new RegisterStateDTO();
            return dto;
        }// End of ObjectToDTO function
    }// End of RegisterStateAdapter class
}
