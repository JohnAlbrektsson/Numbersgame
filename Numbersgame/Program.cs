//John Albrektsson, SUT22
using System;

namespace Numbersgame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rn = new Random(); 
            int numgen = rn.Next(1, 20); //Sets the numgen to a random number between 1 and 20
            int guessnum = 0;
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
            
            
            while (guessnum < 5) //While guessnum is lower than 5 this loop keeps going
            {
                int guess = int.Parse(Console.ReadLine());  //stores the user input as an int
                guessnum = Checkguess(guess, numgen, guessnum); //calls for the Checkguess method
            }
            if (guessnum == 5) //if guessnum becomes 5 this is executed
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök");
            }
        
        }

        public static int Checkguess(int guess, int numgen, int guessnum) //Method for checking the guess the user did compared to the randomly generated number
        {
            if (guess == numgen) //if guess is equal to numgen this is done
            {
                Console.WriteLine("Woho! Du gjorde det!");
                return guessnum + 6; //Increases guessnum by 6
            }
            else if (guess > numgen) //if guess is higher than numgen this is done
            {
                Console.WriteLine("Ditt svar är för högt"); 
                return guessnum +1; //increases guessnum by 1
            }
            else //if guess isn't equal or higher than numgen this is done
            {
                Console.WriteLine("Ditt svar är för lågt");
                return guessnum +1; //increases guessnum by 1 
            }

           
        }
       
    }

}
