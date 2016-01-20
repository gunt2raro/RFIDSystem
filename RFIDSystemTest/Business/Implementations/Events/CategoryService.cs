using RFIDSystemTest.Business.Interfaces.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Business.Implementations.Events
{
    /// <summary>
    /// Implementation Category service
    /// Method Reference :/Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class CategoryService : ICategoryService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public CategoryService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

        /// <summary>
        /// Add category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Category addCategory(Category category, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of addCategory function

        /// <summary>
        /// Delete category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteCategory(Category category, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of deleteCategory function

        /// <summary>
        /// Get by age
        /// </summary>
        /// <param name="age"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Category> getByAge(int age, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByAge function

        /// <summary>
        /// Get by color
        /// </summary>
        /// <param name="color"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Category getByColor(string color, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByColor function

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="category_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Category getById(int category_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getById function

        /// <summary>
        /// Get by name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Category getByName(string name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of getByName function

        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public Category updateCategory(Category category, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of updateCategory function

    }// End of CategoryRepository class
}
