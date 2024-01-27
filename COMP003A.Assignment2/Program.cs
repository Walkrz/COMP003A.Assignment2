/* Author: Zachary Walker
 * Course: COMP-003A-L01
 * Purpose: Code for Assignment 2
 */
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console Section
            Console.Write("***************************************\n");
            Console.Write("Console Section\n");
            Console.Write("***************************************\n");
            Console.Write("\n");
              Console.Write("\n");
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;


            // String Section
            Console.Write("***************************************\n");
            Console.Write("String Section\n");
            Console.Write("***************************************\n");

            // Ask for first name
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            // Ask for middle name
            Console.Write("Enter Middle Name: ");
            string middleName = Console.ReadLine();

            // Ask for last name
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            // Ask for age
            Console.Write("Enter your age in 2024: ");
            int inputAge = int.Parse(Console.ReadLine());

            // Calculate birth year, not just 2023
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - inputAge;

            // Display full name and birth year
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {birthYear}");
        }
    }
}
