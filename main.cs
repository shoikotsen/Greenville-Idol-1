using System;

class Program
{
    // Main entry point of the program
    static void Main(string[] args)
    {
        // Create an instance of the Calculate class
        Calculate calculate = new Calculate();
        // Display the program's motto at the start
        DisplayMotto();
        // Start an infinite loop to display the menu and handle user choices
        while (true)
        {
            
            // Display the menu options to the user
            DisplayMenu();
            // Read the user's choice from the console input
            string choice = Console.ReadLine();
            // Check the user's choice and perform the corresponding action
            if (choice == "1")
            {
                // Prompt the user to enter the number of contestants from the previous year
                Console.Write("Enter the number of contestants from the previous year: ");
                int previousYearContestants = int.Parse(Console.ReadLine());
                // Prompt the user to enter the number of contestants for the current year
                Console.Write("Enter the number of contestants for the current year: ");
                int currentYearContestants = int.Parse(Console.ReadLine());

                // Compare the number of contestants and display the results
                
                calculate.CompareContestants(previousYearContestants, currentYearContestants);
                // Display the motto again after the comparison
                DisplayMotto();
            }
            else if (choice == "2")
            {
                // If the user chooses to exit, display a goodbye message and break the loop
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                break;
            }
            else
            {
                // If the user enters an invalid choice, prompt them to select again
                Console.WriteLine("Invalid choice, please select again.");
            }
        }
    }
    // Method to display the program's motto
    static void DisplayMotto()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("* The stars shine in Greenville. *");
        Console.WriteLine("*********************************");
    }
    
    // Method to display the menu options to the user
    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }
}
// 2024/7/5_Sen_Shoikot_Project 0-2: [Greenville County Fair] GreenvilleRevenue v0.2