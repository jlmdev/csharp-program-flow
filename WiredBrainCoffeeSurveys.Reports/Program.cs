using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            double responseRate;
            double unansweredCount;

            responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            
            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
        }
    }
}
