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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
            }
        }
    }
}
