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
    /// Authentication adapter
    /// </summary>
    public static class AuthenticationAdapter
    {
        /// <summary>
        /// Object to data transfer object
        /// </summary>
        /// <param name="authentication"></param>
        /// <returns></returns>
        public static AuthenticationDTO ObjectToDTO( Authentication  authentication ) {
            AuthenticationDTO dto = new AuthenticationDTO();
            return dto;
        }// End of ObjectToDTO function

    }// End of AuthenticationAdapter class
}
