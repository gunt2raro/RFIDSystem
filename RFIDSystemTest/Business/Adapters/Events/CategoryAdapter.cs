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

            dto.user = category.user;
            dto.age_1 = category.age_1;
            dto.age_2 = category.age_2;
            dto.name = category.name;
            dto.description = category.description;
            dto.color = category.color;

            dto.timestamp = DataConvert.DateTimeToJsonString(category.timestamp);
            dto.updated = DataConvert.DateTimeToJsonString(category.updated);

            return dto;

        }// End of Object To DTO function

        public static Category DTOToObject(CategoryDTO dto)
        {
            return new Category
            {
                age_1=dto.age_1,
                age_2=dto.age_2,
                color=dto.color,
                description=dto.description,
                name=dto.name,
                user=dto.user,
                timestamp=DataConvert.StringJsonToDateTime(dto.timestamp),
                updated=DataConvert.StringJsonToDateTime(dto.updated)
            };

        }


        public static IList<CategoryDTO> ObjectsToDTOs(IList<Category> objs)
        {

            IList<CategoryDTO> list = new List<CategoryDTO>();

            foreach (Category obj in objs)
            {

                CategoryDTO dto = ObjectToDTO(obj);
                list.Add(dto);
            }

            return list;
        }

        public static IList<Category> DTOsToObjects(IList<CategoryDTO> dtos)
        {

            IList<Category> list = new List<Category>();

            foreach (CategoryDTO dto in dtos)
            {

                Category obj = DTOToObject(dto);
                list.Add(obj);
            }

            return list;
        }


    }// End of Category Adapter class
}
