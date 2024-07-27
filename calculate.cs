using System;

public class Calculate
{
    // Method to compare the number of contestants from the previous year and the current year
    public void CompareContestants(int previousYearContestants, int currentYearContestants)
    {
        // Display the number of contestants for both years
        Console.WriteLine($"Last year's competition had {previousYearContestants} contestants, " +
                          $"and this year's has {currentYearContestants} contestants.");
        // Check if the number of contestants this year is more than twice the number from last year
        if (currentYearContestants > previousYearContestants * 2)
        {
            // Display a message indicating the competition has more than doubled
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        // Check if the number of contestants this year is greater than last year
        else if (currentYearContestants > previousYearContestants)
        {
            // Display a message indicating the competition is bigger than ever

            Console.WriteLine("The competition is bigger than ever!");
        }
        // If the number of contestants this year is less than or equal to last year
        else
        {
            // Display a message indicating a closer competition
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}
// 2024/7/5_Sen_Shoikot_Project 0-2: [Greenville County Fair] GreenvilleRevenue v0.2