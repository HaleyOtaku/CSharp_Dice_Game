//Following this tutorial => https://youtu.be/ny5nIQMOkk0?si=JWv2av95XnSk64b6

namespace C__Dice_Game
{
    //Removed internal from class name
     class Program
    {
        static void Main(string[] args)
        {
            #region For Loop Notes 
            //For Loops:

            //Initializer - Happens the first time a loop is called
            //int i = 0 is creating an integer named i and setting it to 0

            //Condition - The loop will keep running as long as this condition is TRUE
            //i < length

            //Incrementer(Iterator) - 
            //i++ (Same as i = i + 1)
            #endregion
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                //Random is lower inclusive and upper exclusive. The code below generates one number from 1 UP TO 7 but not including 7, and stores it in the integer variable playerRandomNum.
                playerRandomNum = random.Next(1,7);

                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                //The below code makes the program wait for 1000 milliseconds (also equivalent to 1 second) before continuing on to the next line of code, since code reads top to bottom, left to right like we do.
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1,7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if (playerPoints <  enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();
        }
    }
}
