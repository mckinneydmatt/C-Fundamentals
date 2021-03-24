using RepositoryPatterns;
using StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContentConsole
{
    public class ProgramUI
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option you would like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        break;
                    case "3":
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue.......");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent content = new StreamingContent();

            Console.WriteLine("Welcome to your Streaming Content Creator Page!");

            Console.WriteLine("Please enter a title:");
            content.Title = Console.ReadLine();

            Console.WriteLine("Please enter a description:");
            content.Description = Console.ReadLine();

            Console.WriteLine("Please enter a star rating (1-10):");
            content.StarRating = double.Parse(Console.ReadLine());

            Console.WriteLine("Select a Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. NC_17\n" +
                "6. TV_Y\n" +
                "7. TV_G\n" +
                "8. TV_PG\n" +
                "9. TV_14\n" +
                "10. TV_MA");
            string maturityRating = Console.ReadLine();

            switch (maturityRating)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_Y;
                    break;
                case "7":
                    content.MaturityRating = MaturityRating.TV_G;
                    break;
                case "8":
                    content.MaturityRating = MaturityRating.TV_PG;
                    break;
                case "9":
                    content.MaturityRating = MaturityRating.TV_14;
                    break;
                case "10":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }

            Console.WriteLine("Select a Genre Type: Select a number between 1 and 7\n" +
                "1:Horror\n" +
                "2:RomCom\n" +
                "3:SciFi\n" +
                "4:Documentary\n" +
                "5:Bromance\n" +
                "6:Drama\n" +
                "7:Action");

            string genreInput = Console.ReadLine();

            int genreID = int.Parse(genreInput);

            content.GenreType = (GenreType)genreID;

            _streamingRepo.AddContentToDirectory(content);
        }

        private void ShowAllContent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _streamingRepo.GetContent();
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue......");
            Console.ReadKey();

        }

        private void RemoveContentFromList()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContent();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }

            int targetContentID = int.Parse(Console.ReadLine());
            int targetIndex = targetContentID - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];

                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} was successfully removed.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }

            else
            {
                Console.WriteLine("No content has that ID");
            }

            Console.WriteLine("Press any key to continue.......");
            Console.ReadKey();
        }



        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Please enter a title.");
            string title = Console.ReadLine();
            StreamingContent content = _streamingRepo.GetContentByTitle(title);
            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("Invalid title. Could not find results.");
            }
            Console.WriteLine("Press any key to continue........");
            Console.ReadKey();
        }

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title}\n" +
            $"Description: {content.Description}\n" +
            $"Star Rating: {content.StarRating}\n" +
            $"Maturity Rating: {content.MaturityRating}\n" +
            $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
            $"Genre: {content.GenreType}");
        }

        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tire comes to life and kills people.", MaturityRating.R, GenreType.Drama, 5.8);
            StreamingContent toystory = new StreamingContent("Toy Story", "Best childhood movie", MaturityRating.G, GenreType.Bromance, 10.0d);
            StreamingContent starwars = new StreamingContent("Star Wars", "Jar Jar saves the world.", MaturityRating.PG_13, GenreType.SciFi, 9.2);
            StreamingContent snowden = new StreamingContent("Snowden", "Our first real date.", MaturityRating.R, GenreType.Drama, 10);

            _streamingRepo.AddContentToDirectory(rubber);
            _streamingRepo.AddContentToDirectory(toystory);
            _streamingRepo.AddContentToDirectory(starwars);
            _streamingRepo.AddContentToDirectory(snowden);



        }


    }
}

