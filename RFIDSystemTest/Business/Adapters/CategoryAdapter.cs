using RFIDSystemTest.Business.DTO;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters
{
    /// <summary>
    /// Category Adapter
    /// </summary>
    public static class CategoryAdapter
    {
        /// <summary>
        /// Object To Data Transfer Object
        /// </summary>
        /// <param name="competitor"></param>
        /// <returns></returns>
        public static CategoryDTO ObjectToDTO(Category category)
        {

            CategoryDTO dto = new CategoryDTO();

            dto.age_1 = category.age_1;
            dto.age_2 = category.age_2;
            dto.name = category.name;
            dto.description = category.description;
            dto.color = category.color;

            dto.timestamp = DataConvert.DateTimeToJsonString(category.timestamp);
            dto.updated = DataConvert.DateTimeToJsonString(category.updated);

            return dto;

        }// End of Object To DTO function

    }// End of Category Adapter class
}
