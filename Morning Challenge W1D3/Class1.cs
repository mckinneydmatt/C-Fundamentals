//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Morning_Challenges
//{
//    public class ProgramUI
//    {
//        private readonly DevTeamRepo _teamDirectory = new DevTeamRepo();
//        public void Run()
//        {
//            SeedContentList();
//            RunMenu();
//        }
//        private void RunMenu()
//        {
//            bool continueToRun = true;
//            while (continueToRun)
//            {
//                Console.Clear();

//                Console.WriteLine("Hello. Enter the number for the option you want to select.\n" +
//                    "1. Show all developer teams\n" +
//                    "2. Add a new developer team\n" +
//                    "3. Delete a developer team\n" +
//                    "4. Add a new member to a dev team\n" +
//                    "5. Delete a member of a dev team\n" +
//                    "6. Exit");

//                string userInput = Console.ReadLine();

//                switch (userInput)
//                {
//                    case "1":
//                        ShowAllTeams();
//                        break;
//                    case "2":
//                        AddTeamToDirectory();
//                        break;
//                    case "3":
//                        DeleteTeam();
//                        break;
//                    case "4":
//                        AddPersonToDirectory();
//                        break;
//                    case "5":
//                        DeleteMember();
//                        break;
//                    case "6":
//                        continueToRun = false;
//                        break;
//                    default:
//                        Console.WriteLine("Please enter a valid number.\n" +
//                            "Press any key to continue");
//                        Console.ReadKey();
//                        break;
//                }

//            }
//        }

//        private void ShowAllTeams()
//        {
//            Console.Clear();

//            List<DeveloperTeam> listOfTeams = _teamDirectory.GetDeveloperTeams();
//            foreach (DeveloperTeam teams in listOfTeams)
//            {
//                DisplayTeams(teams);
//            }
//            Console.WriteLine("Press any key to continue......");
//            Console.ReadKey();

//        }
//        private void DisplayTeams(DeveloperTeam teams)
//        {
//            Console.WriteLine($"Team Name: {teams.TeamName}\n" +
//                $"Team ID: {teams.TeamID}\n" +
//                $"Developers: ");
//        }

//    }
//}

