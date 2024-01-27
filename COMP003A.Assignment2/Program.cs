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
            Console.WriteLine("***************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("***************************************");
            Console.Write("\n");
            Console.Write("\n");
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            // String Section
            Console.WriteLine("***************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("***************************************");

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

            // Calculate birth year, not just 2023 (Subtracted 1 for sake of birthday not happening yet)
            int currentYear = DateTime.Now.Year;
            int yearBorn = currentYear - inputAge -1;

            // Display full name and birth year
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}");
            Console.Write("\n");
            Console.Write("\n");

            // Math Section
            Console.WriteLine("***************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("***************************************");

            // Prompt User
            Console.Write("Enter an Integer for integer1: ");
            int integer1 = int.Parse(Console.ReadLine());
            Console.Write("Enter an Integer for integer2: ");
            int integer2 = int.Parse(Console.ReadLine());

            // Sum (+)
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");

            // Difference (-)
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");

            // Product (*)
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");

            // Quotient (/)
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");

            // Remainder (%)
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
            Console.Write("\n");
            Console.Write("\n");

            // Circle Section
            Console.WriteLine("***************************************");
            Console.WriteLine("Circle Area & Circumferece Calculator Section");
            Console.WriteLine("***************************************");

            // Prompt User
            Console.Write("Enter radius: ");

            // Backend Math
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            //Output
            Console.WriteLine($"The area is: {area}");
            Console.WriteLine($"The circumference is: {circumference}");


        }
    }
}
