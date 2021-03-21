using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Appearance
            Console.Title = "Food Orders";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 40;
            
            //Machine Asks For Breakfast
             Console.WriteLine("Hello!, Whats your name?");
            string userName =  Console.ReadLine();   
            Console.WriteLine("Hello! " + userName + ", Nice to meet you");
            Console.WriteLine("___________________________________________________________________________________________");
            Console.WriteLine("What Would you like to eat?");
            string userBreakfast = Console.ReadLine();
            Console.WriteLine("So you would like to eat " +  userBreakfast + ", for breakfast");
            Console.ReadLine();
            //_______________________________________________________________________________________________
            Console.WriteLine("________________________________________________________________________________________________________");
            Console.WriteLine("What would you like to drink(say nothing if nothing)");
            string userDrink = Console.ReadLine();
            Console.WriteLine("So you would like " + userDrink + ", to drink?");
            Console.ReadLine();    
            //__________________________________________________________________
            //Asks about lunch
            Console.WriteLine("_____________________________________________________________________________________________________");
            Console.WriteLine("Whats would you like to eat for lunch");
            string userLunch = Console.ReadLine();

            Console.WriteLine("Ok So you want " + userLunch + ", for lunch! Is This Correct?");
            Console.ReadLine();
            //_____________________________________________________________________________________________________
            //_____________________________________________________________________________________________________
            // Machine Ask For Dinner
            Console.WriteLine("______________________________________________________________________________________________________________________________");
            Console.WriteLine("What do you want for Dinner?");
            string userDinner = Console.ReadLine();

            Console.WriteLine("Ok so you want to eat " + userDinner + ", for dinner Is this correct?");
            Console.ReadLine();
            Console.WriteLine("_______________________________________________________________________________________________________________");
            Console.WriteLine("Anything else you would like some more drinks or snacks");
            string userDrinkSnack = Console.ReadLine();
            Console.WriteLine("So you would like " + userDrinkSnack + ", for A Drink or a Snack");
            Console.ReadLine();
            //_______________________________________________________________________________________________________
            //_______________________________________________________________________________________________________
            //Prints List
            Console.WriteLine("_____________________________________________________________________________________________");
            Console.WriteLine("_____________________________________________________________________________________________");
            Console.WriteLine("You would like " + userBreakfast + ", for BreakFast");
            Console.WriteLine("You would like " + userLunch + ", for Lunch");
            Console.WriteLine("You would like " + userDinner + ", for Dinner");
            Console.WriteLine("You would like " + userDrinkSnack + ", for the day");
            Console.WriteLine("Is that what you would like to eat?");
            Console.ReadLine();



            //________________________________________________________________________________________________________________________________
            //________________________________________________________________________________________________________________________________
            //________________________________________________________________________________________________________________________________
            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("You have picked what you want to eat if you would like to change you mind please contact Ammaar!");
            Console.WriteLine("____________________________________________________________________________________________");
            //Form Is Done ^^^^

            Console.ReadKey();
        }
    }
}
