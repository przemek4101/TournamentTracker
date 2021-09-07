using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public void CompleteTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public void CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public void CreatePrize(PrizeModel model)
        {
            
            model.Id = 1;

            

        }

        public void CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetTeam_All()
        {
            throw new NotImplementedException();
        }

        public List<TournamentModel> GetTournament_All()
        {
            throw new NotImplementedException();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            throw new NotImplementedException();
        }

        void IDataConnection.CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        void IDataConnection.CreatePrize(PrizeModel model)
        {
            throw new NotImplementedException();
        }

        void IDataConnection.CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }
    }
}
