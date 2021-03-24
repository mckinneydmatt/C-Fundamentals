using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenges
{
    [TestClass]
    public class DeveloperTeam
    {
        private readonly List<Developer> _developers;

        public string TeamName { get; set; }
        public int TeamID { get; set; }


        public DeveloperTeam(string teamName, int teamID)
        {
            TeamName = teamName;
            TeamID = teamID;
            _developers = new List<Developer>();
        }



        //adding a new person, or member, to directory
        public bool AddPersontoDirectory(Developer member)
        {
            int startingCount = _developers.Count;
            //adding a member
            _developers.Add(member);
            // if a person was added, return was added
            //removing bool wasAdded = (return Developers.Count > startingCount), to return wasAdded
            return _developers.Count > startingCount;
        }

        //trying to delete member of a dev team
        public bool DeleteMember(int identifier)
        {
            //for each person in the team
            foreach (Developer member in _developers)
            {

                //check if a identifier input matches the identifier 
                if (member.Identifier == identifier)
                {
                    // 
                    bool deleteResult = _developers.Remove(member);
                    return deleteResult;
                }
            }
            return false;

        }


    }
}
