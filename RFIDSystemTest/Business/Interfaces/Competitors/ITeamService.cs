using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Interfaces.Competitors
{
    public interface ITeamService
    {
        IList<Team> getAll(UserSystem user_log);
        IList<Team> getByName(string team_name, UserSystem user_log);
        IList<Team> getByCity(string team_city, UserSystem user_log);
        IList<Team> getByState(string team_state, UserSystem user_log);
        IList<Team> getByCountry(string team_country, UserSystem user_log);

        Team getById(int team_id, UserSystem user_log);
        Team getByTeam(Team team, UserSystem user_log);
        Team getByDate(DateTime date, UserSystem user_log);

        Team addTeam(Team team, UserSystem user_log);
        Team updateTeam(Team team, UserSystem user_log);

        bool deleteTeam(int team_id, UserSystem user_log);
        int getTeamNum(int team_id, UserSystem user_log);

    }
}
