using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class ProgramUI
    {

        int playerHealth = 100;

        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Press 1 to begin the game.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DungeonBegin();
                        break;
                    default:
                        continueToRun = false;
                        break;

                }
                if (playerHealth <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have died. Better luck next time.");
                    Console.ReadKey();
                    continueToRun = false;
                }
            }
        }

        private void DungeonBegin()
        {
            Console.Clear();

            Console.WriteLine("You awaken in a large stone chamber. You notice a lantern at your feet. \n" +
                "You light it, illuminating two tunnels in your path.\n" +
                "Do you take the LEFT path or the RIGHT path?");

            string leftOrRight = Console.ReadLine().ToLower();

            Console.Clear();

            switch (leftOrRight)
            {
                case "left":
                    DungeonLeft();
                    break;
                case "right":
                    DungeonRight();
                    break;
                default:
                    DungeonBegin();
                    break;

            }
        }

        private void DungeonLeft()
        {
            Console.Clear();

            Console.WriteLine("You enter a small, lightly furnished room, with three doors opposite you. \n" +
                "In the dim lantern light, You can make out three symbols corresponding to each door. \n" +
                "On the first one lay a lion in rest. The second depicts a coiled snake, while the last shows a rat, arched to pounce. \n" +
                "Which door do you choose?");

            Console.WriteLine("LION, RAT, or SNAKE?");

            string animalAnswer = Console.ReadLine().ToLower();

            if (animalAnswer == "lion")
            {
                Console.Clear();
                Console.WriteLine("You enter the lion door, hoping to not see the creature depicted. But no such luck. \n" +
                    "As you enter a large, circular room, you see the next door - a heavy, stone door with a gold star on it. \n" +
                    "But between you and that door is a roaring lion. It looks hungry.");
                Console.ReadKey();
                Console.WriteLine("Should you FIGHT the lion, or turn BACK to the previous room?");
                Console.WriteLine("FIGHT or BACK");
                string lionFight = Console.ReadLine().ToLower();
                if (lionFight == "fight")
                {
                    Console.Clear();
                    Console.WriteLine("You charge the lion, armed with only the fire from your lantern. It holds its ground and takes a swipe at your chest, breaking the skin.\n" +
                        "You bring your lantern down on its head, disorienting it long enough to hurry through the door.");
                    playerHealth = playerHealth - 40;
                    Console.WriteLine($"Health: {playerHealth}/100 ");
                    Console.ReadKey();
                    StarRoom();
                }
                else if (lionFight == "back")
                {
                    Console.Clear();
                    Console.WriteLine("You turn back to the last room as the lion starts to charge. You shut the door just in time, leaving what was behind the next door a mystery forever.");
                    DungeonLeftTwo();
                }

            }
            else if (animalAnswer == "rat")
            {
                RatRoom();
            }
            else if (animalAnswer == "snake")
            {
                SnakeRoom();
            }

        }

        private void RatRoom()
        {
            Console.Clear();
            Console.WriteLine("You walk into the chamber, and a rat jumps on your leg, managing to take a small chunk out before you can kick it away.");
            playerHealth = playerHealth - 10;
            Console.WriteLine($"Health: {playerHealth}/100 ");
        }

        private void SnakeRoom()
        {
            Console.Clear();
            Console.WriteLine("You enter the room with the snake on the door.\n" +
                "On the back wall is a series of levers. It looks like a snake made of levers is encircling the room.\n" +
                "As you look closely at each lever, you see they're numbered. You walk around the room and get to the end. There are 100 levers.\n" +
                "After some time, you hear a voice from somewhere in the walls...\n" +
                "\"Ifffff you want to continueeeee, you mussssst prove yourselfff...\"\n" +
                "On the wall appears the following problem:\n" +
                "4 × (5 + 3) = ???");
            Console.WriteLine("Which lever do you pull?");
            
            string snakeRiddle = Console.ReadLine();

            if (snakeRiddle == "32")
            {
                Console.WriteLine("You hear the voice again...\n" +
                    "\"Yesssss, you've ssssolved ittttt.\"");
                Console.Clear();
                Console.WriteLine("A door in the back cracks open. How did you not see that when you entered?");
            }
            else
            {
                Console.WriteLine("You hear the voice again...\n" +
                    "\"Oooh, sssssorrrry. I don't think you're ready for what's nexxxxxt.\"");
                Console.Clear();
                Console.WriteLine("Suddenly, the floor falls out from under you.\n" +
                    "You fall into a chasm, landing on sand below, but slightly injured.");
                playerHealth = playerHealth - 20;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                QuicksandRoom();
            }
        }

        private void QuicksandRoom()
        {
            Console.Clear();
            Console.WriteLine("With sand under your feet, you stand up to get your bearings.\n" +
                "Before you can look around, the sand starts to crumble, and you start to sink.\n" +
                "As you start to slide in, you hear a faint voice...\n" +
                "\"I can help you, but you must guess the number I'm thinking of! It's between 1 and 10!\"");
            
            
            Random rnd = new Random();
            
            int randomNum = rnd.Next(1, 11);
            for (int guesses = 2; guesses < 9; guesses++)
            {
                int quicksandGuess = Int32.Parse(Console.ReadLine());

                if (guesses == 1 && quicksandGuess == randomNum)
                {
                    Console.WriteLine("You find your footing as you no longer feel yourself being pulled down.\n" +
                        "\"Wow, first try!\"");
                    break;
                }
                else if (guesses > 1 && guesses < 5 && quicksandGuess == randomNum)
                {
                    Console.WriteLine("You find your footing as you no longer feel yourself being pulled down.\n" +
                        "\"You got it!\"");
                    break;
                }
                else if (guesses == 5 && quicksandGuess == randomNum)
                {
                    Console.WriteLine("You find your footing as you no longer feel yourself being pulled down.\n" +
                       "\"On the last try, you got it!\"");
                    break;
                }
                else if (guesses < 6 && quicksandGuess < randomNum)
                {
                    Console.WriteLine("You continue to be pulled into the ground.\n" +
                        "\"Hmmm, not quite! Try a little higher!\"");
                }
                else if (guesses < 6 && quicksandGuess > randomNum)
                {
                    Console.WriteLine("You continue to be pulled into the ground.\n" +
                        "\"Hmmm, not quite! Try a little lower!\"");
                }
                else if (guesses > 5)
                {
                    Console.WriteLine("The sand enters your mouth and nose as you sink into the ground, never to be found again.");
                    playerHealth = playerHealth - 100;
                    break;
                }
            }

             Console.ReadKey();
        }



        private void DungeonLeftTwo()
        {
            Console.Clear();

            Console.WriteLine("You're back in the last room, with three doors opposite you. \n" +
                "On the first one lay a lion in rest - you're not going back in there.\n" +
                "The second depicts a coiled snake, while the last shows a rat, arched to pounce. \n" +
                "Which door do you choose?");

            Console.WriteLine("RAT, or SNAKE?");

            string animalAnswerAgain = Console.ReadLine().ToLower();

            if (animalAnswerAgain == "rat")
            {
                RatRoom();
            }
            else if (animalAnswerAgain == "snake")
            {
                SnakeRoom();
            }

        }

        private void StarRoom()
        {
            Console.Clear();
            Console.WriteLine("You enter the room with the star on the door. There's a chest on a table, with yet another door behind it.\n" +
                "You go to open the chest, but you hear a voice booming throughout the dungeon...");

            Console.WriteLine("You can have your reward, only if you answer my riddle.\n" +
                "What is the most common type of star?\n" +
                "1. Red dwarf\n" +
                "2. Red giant\n" +
                "3. Black hole");
            Console.WriteLine("Choose the number for your answer: 1, 2 or 3");
            string starRiddle = Console.ReadLine();
            switch (starRiddle)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("The voice bellows at you after you say your answer: 'Correct!'");
                    Console.WriteLine("The chest opens, and you find a beaker with a glowing red liquid. You can feel the energy coming off the bottle.\n" +
                        "You take a drink of the liquid and you feel your skin began to stitch itself back together. Horrified, you realize that your wound has completely healed in an instant.\n" +
                        "You enter the door behind the table, ready to face what's next.");
                    playerHealth = playerHealth + 20;
                    Console.WriteLine($"Health: {playerHealth}/100 ");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("The voice bellows at you after you say your answer: 'Not quite!'");
                    Console.WriteLine("The chest opens, and a small dart strikes you in the arm. You feel weaker after pulling the dart out.\n" +
                        "You enter the door behind the table, hoping that was the last surprise you see.");
                    playerHealth = playerHealth - 10;
                    Console.WriteLine($"Health: {playerHealth}/100 ");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("The voice bellows at you after you say your answer: 'Did you really think it was that?'");
                    Console.WriteLine("The chest opens, but it's empty. Suddenly, you feel the ground beneath you crumble as you fall into an awaiting spike pit.");
                    playerHealth = playerHealth - 100;
                    break;
            }
        }

        private void DungeonRight()
        {
            Console.Clear();

            Console.WriteLine("You choose the right path, hoping it leads to success and freedom from the dungeon.");

            Console.Clear();

            Console.WriteLine("After walking for a bit, you come across a wide gap, with a small ledge along the side. Do you try and jump the gap, or maneuver around it on the ledge?");

            Console.WriteLine("JUMP or LEDGE");

            string gapAnswer = Console.ReadLine().ToLower();

            Console.Clear();

            if (gapAnswer == "jump")
            {
                Console.WriteLine("You get a running start, and leap with everything you have. Immediately, you realize you're not going to make it. You try and grab at anything to keep from falling through the gap, but it's no use. You fall into the pit, splashing down into an underground reservoir.");
                playerHealth = playerHealth - 20;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Reservoir();
            }
            else if (gapAnswer == "ledge")
            {
                Console.WriteLine("Your heart beats in your chest as you carefully step your way across the gap to the other side. You look down at what could've been your fate had you fallen, but only seeing darkness.");

            }

        }

        private void Reservoir()
        {
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();

            Console.WriteLine("You come up for air, thankful to find some deep underground. As your eyes adjust to the darkness in the water, you notice a path forward in the water. But you have no idea where it could lead. You look up at the chasm and see some jagged rocks sticking out of the wall. You could try to climb your way back up, risking another fall.");

            Console.WriteLine("CLIMB or SWIM");

            string waterAnswer = Console.ReadLine().ToLower();

            Console.Clear();

            if (waterAnswer == "climb")
            {
                Console.Clear();
                Console.WriteLine("You make your way up the ");
            }
            else if (waterAnswer == "swim")
            {
                Console.WriteLine("You decide to swim forward, but come across two different openings in the submerged cave wall.");
                Swim();
            }

        }

        private void Swim()
        {
            Console.Clear();

            Console.WriteLine("Do you take the narrow underwater path with a light at the end, or the more wide, darker underwater path?");
            Console.WriteLine("NARROW or WIDE?");
            string swimAnswer = Console.ReadLine().ToLower();

            if (swimAnswer == "narrow")
            {
                Console.WriteLine("Gasping for air, you emerge in a small open pocket deep underground. Looking around, you spot a strange hatch leading up.");
            }
            else if (swimAnswer == "wide")
            {
                Console.Clear();
                Console.WriteLine("You swim until your arms start to get sore, not to mention your lungs running out of air. Eventually you lose your bearings ... which way did you come from? Where did you start? You start to lose consciousness as the water and darkness envelops you...");
                Console.ReadKey();
                playerHealth = playerHealth - 100;
            }
        }
    }
}



// choose your own adventure game
// Mostly using IF statements, leading to some branching paths
// dungeon-based, exploring, finding things to do
// traps that reset the game, sending player back to start spot
// (Maybe) health for player with basic combat??
//
//"Gasping for air, you emerge in a small open pocket deep underground. Looking around, you spot a strange hatch leading up."

//
//        like "You feel a pain in your thigh, and notice an small dart sticking out of it. -10 health."
//"You walk into the chamber, and a rat jumps on your leg, managing to take a small chunk out before you can kick it away. -10 health"

//
//
//
