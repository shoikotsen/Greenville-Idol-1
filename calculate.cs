using System;

public class Calculate
{
    public void CompareContestants(int previousYearContestants, int currentYearContestants)
    {
        Console.WriteLine($"Last year's competition had {previousYearContestants} contestants, " +
                          $"and this year's has {currentYearContestants} contestants.");

        if (currentYearContestants > previousYearContestants * 2)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (currentYearContestants > previousYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}
// 2024/7/5_Sen_Shoikot_Project 0-2: [Greenville County Fair] GreenvilleRevenue v0.2