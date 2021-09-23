using System;

namespace SimpleNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run GetAppInfo funtion get info
            GetAppInfo();

            //Ask for users name and greet
            GreetUser();

            

            while (true) {

                int range = AskDifficultyLevel();
               

                //Create a new Random object
                Random random = new Random();

                //Init correct number
                //int correctNumber = random.Next(1, range);
                int correctNumber = 55;
                // Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and {0}", range);

                //While guess is not correct
                while (guess != correctNumber){

                    //Get user input
                    string input = Console.ReadLine();
                    
                    //Make sure its a number
                    if (!int.TryParse(input, out guess)){

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if(guess != correctNumber){

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Print success messsage
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT !! You guessed it!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y"){
                    continue;
                }else {
                    return;
                }
            }

            //Get and display app info
            static void GetAppInfo() {

                //Set app vars
                string appName = "Number Guesser (by youtube video from Traversy Media";
                string appVersion = "1.0.0";
                string appAuthor = "Romano Castagnoli";

                //Change text color
                Console.ForegroundColor = ConsoleColor.Green;

                //Write out app info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                //Reset text color
                Console.ResetColor();
            }

            //Ask users name and greet
            static void GreetUser(){

                //Ask users name
                Console.WriteLine("What is your name?");

                //Get user input
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, i would like to play a game ...", inputName);
            }

            //Print color message
            static void PrintColorMessage(ConsoleColor color, string message){

                //Change text color
                Console.ForegroundColor = color;

                //Tell user its not a number
                Console.WriteLine(message);

                //Reset text color
                Console.ResetColor();
            }

            //Ask the difficulty level
            static int AskDifficultyLevel() {
                while (true){
                    //Ask the difficulty
                    Console.WriteLine("Choose the from one to xy number, you want to guess");
                    string maxLevel = Console.ReadLine();

                    //Init range 
                    int range = 0;

                    //Make sure its a number
                    if (!int.TryParse(maxLevel, out range))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }

                    //Cast to int and put in range
                    range = Int32.Parse(maxLevel);

                    return range;
                }
            }
            
        }
    }
}
