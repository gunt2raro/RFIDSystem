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
    /// Competitor Adapter
    /// </summary>
    public static class CompetitorAdapter
    {

        /// <summary>
        /// Object To Data Transfer Object
        /// </summary>
        /// <param name="competitor"></param>
        /// <returns></returns>
        public static CompetitorDTO ObjectToDTO( Competitor competitor ) {

            CompetitorDTO dto = new CompetitorDTO();
            
            dto.name = competitor.name;
            dto.email = competitor.email;
            dto.second_name = competitor.second_name;
            dto.city = competitor.city;
            dto.state = competitor.state;
            dto.country = competitor.country;
            dto.zip_code = competitor.zip_code;
            dto.address = competitor.address;
            dto.address2 = competitor.address2;
            dto.phone_number = competitor.phone_number;
            dto.sex = competitor.sex;

            dto.birth_date = DataConvert.DateTimeToJsonString( competitor.birth_date );
            dto.timestamp = DataConvert.DateTimeToJsonString( competitor.timestamp );
            dto.updated = DataConvert.DateTimeToJsonString( competitor.updated );

            return dto;
                        
        }// End of Object To DTO function

    }// End of Competitor Adapter class
}
