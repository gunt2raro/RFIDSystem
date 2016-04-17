using RFIDSystemTest.Business.Interfaces.Competitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Users;

namespace RFIDSystemTest.Business.Implementations.Competitors
{
    public class TeamService : ITeamService
    {
        public Team addTeam(Team team, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public bool deleteTeam(int team_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public IList<Team> getAll(UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public IList<Team> getByCity(string team_city, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public IList<Team> getByCountry(string team_country, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public Team getByDate(DateTime date, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public Team getById(int team_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public IList<Team> getByName(string team_name, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public IList<Team> getByState(string team_state, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public Team getByTeam(Team team, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public int getTeamNum(int team_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }

        public Team updateTeam(Team team, UserSystem user_log)
        {
            throw new NotImplementedException();
        }
    }
}
