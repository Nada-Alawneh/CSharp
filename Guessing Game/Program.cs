using System;

namespace Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Guessing Game
            Console.WriteLine("Are you ready to guess the number !!");

            Random rand = new Random();
            int secretNumber = rand.Next(50, 76);
            int attempts = 0;
            int guess = 0;

            while (guess != secretNumber)
            {
                Console.WriteLine("Guess a number between 50 and 75: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Try a lower number.");
                }
                else
                {
                    Console.WriteLine("Congratulations!");
                }
            }

            int points;
            if (attempts == 1)
                points = 10;
            else if (attempts == 2)
                points = 7;
            else if (attempts == 3)
                points = 5;
            else
                points = 0;

            Console.WriteLine($"\nAttempts: {attempts}");
            Console.WriteLine($"Points: {points}");
            Console.WriteLine("______________________");


            // School System
            string[] studentName = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };
            int[] marks = { 85, 92, 68, 75, 90 };

            int choice;
            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Part 1 – Display Students
                        Console.WriteLine("\nStudents:");
                        for (int i = 0; i < studentName.Length; i++)
                        {
                            Console.WriteLine(studentName[i]);
                        }

                        Console.WriteLine("\nGrades:");
                        foreach (int mark in marks)
                        {
                            Console.WriteLine(mark);
                        }
                        break;

                    case 2:
                        // Part 2 – Search for a Student
                        Console.Write("\nEnter student name to search: ");
                        string searchName = Console.ReadLine();
                        int index = 0;
                        bool found = false;

                        while (index < studentName.Length)
                        {
                            if (studentName[index].ToLower() == searchName.ToLower())
                            {
                                Console.WriteLine("Student Found!");
                                found = true;
                                break;
                            }
                            index++;
                        }

                        if (found == false)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;


                    case 3:
                        // Part 3 – Check Student Result
                        Console.Write("\nEnter student grade: ");
                        int grade = Convert.ToInt32(Console.ReadLine());

                        if (grade >= 90 && grade <= 100)
                            Console.WriteLine("Excellent");
                        else if (grade >= 80 && grade <= 89)
                            Console.WriteLine("Very Good");
                        else if (grade >= 70 && grade <= 79)
                            Console.WriteLine("Good");
                        else if (grade >= 60 && grade <= 69)
                            Console.WriteLine("Pass");
                        else
                            Console.WriteLine("Fail");
                        break;

                    case 4:
                        Console.WriteLine("Exiting School System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
