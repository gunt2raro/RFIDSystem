using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Warriror;
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
            return new AuthenticationDTO
            {
                competitor = CompetitorAdapter.ObjectToDTO(authentication.competitor),
                password = authentication.password,
                timestamp = DataConvert.DateTimeToJsonString(authentication.timestamp),
                updated = DataConvert.DateTimeToJsonString(authentication.updated)
                
            };
        }

        public static Authentication DTOToObject(AuthenticationDTO authentication)
        {
            return new Authentication
            {
                competitor = CompetitorAdapter.DTOToObject(authentication.competitor),
                password = authentication.password,
                timestamp = DataConvert.StringJsonToDateTime(authentication.timestamp),
                updated = DataConvert.StringJsonToDateTime(authentication.updated)
            };
        }

        public static IList<AuthenticationDTO> ObjectsToDTOs(IList<Authentication> objs)
        {

            IList<AuthenticationDTO> list = new List<AuthenticationDTO>();

            foreach (Authentication obj in objs)
            {

                AuthenticationDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<Authentication> DTOsToObjects(IList<AuthenticationDTO> dtos)
        {

            IList<Authentication> list = new List<Authentication>();

            foreach (AuthenticationDTO dto in dtos)
            {

                Authentication obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }

   
    }// End of AuthenticationAdapter class
}
