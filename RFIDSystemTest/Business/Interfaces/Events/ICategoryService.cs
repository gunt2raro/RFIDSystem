using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Events
{
    /// <summary>
    /// Interface Category service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public interface ICategoryService
    {
        Category getById(int category_id, UserSystem user_log);
        Category getByName(string name, UserSystem user_log);
        List<Category> getByAge(int age, UserSystem user_log);
        Category getByColor(string color, UserSystem user_log);
        Category addCategory(Category category, UserSystem user_log);
        Category updateCategory(Category category, UserSystem user_log);
        bool deleteCategory(Category category, UserSystem user_log);

    }// End of ICategoryService interface
}
