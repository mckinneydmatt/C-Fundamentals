using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Morning_Challenges
{
    [TestClass]
    public class DevTeamRepo
    {

        protected readonly List<DeveloperTeam> _teamDirectory = new List<DeveloperTeam>();

        [TestMethod]
        //adding a new team to directory
        public bool AddTeamtoDirectory(DeveloperTeam team)
        {
            int startingCount = _teamDirectory.Count;
            //adding a team
            _teamDirectory.Add(team);
            // if a team was added, return was added
            //removing bool wasAdded = (_teamDirectory.Count > startingCount), to return wasAdded
            return _teamDirectory.Count > startingCount;
        }
        [TestMethod]
        //trying to get team by its ID
        public DeveloperTeam GetTeamByID(int teamID)
        {
            //check each team in the directory for the inputted int ID
            foreach (DeveloperTeam team in _teamDirectory)
            {
                //for each ID that equals what was inputted
                if (team.TeamID == teamID)
                {
                    //return that member
                    return team;
                }
            }
            return null;
        }

        [TestMethod]
        //trying to delete member a dev team
        public bool DeleteTeam(int teamID)
        {
            //for each person in the team
            foreach (DeveloperTeam team in _teamDirectory)
            {

                //check if a identifier input matches the identifier 
                if (team.TeamID == teamID)
                {
                    // 
                    bool deleteResult = _teamDirectory.Remove(team);
                    return deleteResult;
                }
            }
            return false;
        }

        //get all dev teams
        public List<DeveloperTeam> GetDeveloperTeams()
        {
            List<DeveloperTeam> allTeams = new List<DeveloperTeam>();

            foreach (DeveloperTeam team in _teamDirectory)
            {
                if (team is DeveloperTeam)
                {
                    allTeams.Add(team as DeveloperTeam);
                }
            }
            return allTeams;
        }

        

    }
}
