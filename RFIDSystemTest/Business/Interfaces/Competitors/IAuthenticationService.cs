using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Competitors
{
    /// <summary>
    /// Interface Authentication service
    /// Method Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public interface IAuthenticationService
    {
        Authentication getById(int authentication_id, UserSystem user_log);
        Authentication getByCompetitor(Competitor competitor, UserSystem user_log);
        Authentication addAuthentication(Authentication authentication, UserSystem user_log);
        Authentication updateAuthentication(Authentication authentication, UserSystem user_log);
        bool deleteAuthentication(Authentication authentication, UserSystem user_log);

    }// End of IAuthentication Service interface
}
