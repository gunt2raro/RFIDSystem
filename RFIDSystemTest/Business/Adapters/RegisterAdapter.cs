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
    /// Register adapter
    /// </summary>
    public static class RegisterAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static RegisterDTO ObjectToDTO(Register register)
        {
            RegisterDTO dto = new RegisterDTO();

            dto.competitor = register.competitor;
            dto.competition = register.competition;
            dto.competitor_num = register.competitor_num;
            dto.category = register.category;
            dto.kit_state = register.kit_state;
            dto.register_state = register.register_state;
            
            return dto;
        }// End of ObjectToDTO function

    }// End of RegisterAdapter classs
}
