using RFIDSystemTest.Business.Interfaces.Competitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Data.Users;
using RFIDSystemTest.Business.Adapters;
using Newtonsoft.Json;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Business.Implementations.Competitors
{
    public class TeamService : ITeamService
    {
        public IHttpService http_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public TeamService(IHttpService http_service)
        {
            this.http_service = http_service;
        }// End of Constructor function

        public Team addTeam(Team team, UserSystem user_log)
        {
            return http_service.JSONHttpPettitionObject<Team>(
                   HttpMethod.POST,
                   GetType().Name.ToLower().Replace(
                       TWords.SERVICE,
                       TWords.SLASH),
                   JsonConvert.SerializeObject(
                       TeamAdapter.ObjectToDTO(
                           team)));
        }// End of add Team function

        /// <summary>
        /// Delete team
        /// </summary>
        /// <param name="team_id"></param>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public bool deleteTeam(int team_id, UserSystem user_log)
        {
            throw new NotImplementedException();
        }// End of delete Team function

        /// <summary>
        /// Get all the teams 
        /// </summary>
        /// <param name="user_log"></param>
        /// <returns></returns>
        public IList<Team> getAll(UserSystem user_log)
        {
            return http_service.JSONHttpPettitionList<Team>(
                HttpMethod.GET,
                GetType().Name.ToLower().Replace(
                    TWords.SERVICE,
                    TWords.EMPTY),
                null);
        }// End of get All function

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
