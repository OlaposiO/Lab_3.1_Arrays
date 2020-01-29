using System;

namespace NewLab_3._1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool again = true;
            bool oneMoreTime = true;
            string[] students;


            do
            {
                //students = new string[] { "Brandon", "Russ", "Ollie", "Brea", "Della", "Edward", "Nick", "Vlad", "Victoria", "Riley" };
                
                 students = new string[] { "Brandon", "Russ", "Ollie", "Brea", "Della", "Edward", "Nick", "Vlad", "Victoria", "Riley" };
                string[] favoriteFood = new string[] { "pie", "Cheese", "Sharwarma", "Tacos", "Cheese Sticks", "Pizza", "Greens", "Bananas", "Pasta", "Potato Salad" };
                string[] previousTitle = new string[] { "Rapper", "Teacher", "Figure Skater", "Tattoo Model", "Teacher", "Dancer", "DeskTop", "BlackSmith", "Singer", "Student" };


                Console.WriteLine($"What student what you like to learn more about? (Pick a number between 1-10)");
                int i = 1;
                    foreach (var student in students)
                    {
                        
                        Console.Write($"{i++}. {student} \n");
                    }
                

                Console.WriteLine();
                do
                {
                    ValidateAnswer(out num, out again, students);
                } while (again == true);


                int userFriendNumer = num - 1;
                string name = students[userFriendNumer];
                string food = favoriteFood[userFriendNumer];
                string job = previousTitle[userFriendNumer];

                Console.WriteLine($"You picked {name}!");

                do
                {
                    again = PersonInfo(name, food, job);
                } while (again == true);


                do
                {
                    again = NewStudent(ref oneMoreTime);
                    
                } while (again == true);

                Array.Clear(students, 0, students.Length);

            } while (oneMoreTime == true);
        }

        private static void ValidateAnswer(out int num, out bool again, string[] students)
        {
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out num);
            if (num > 0 && num <= students.Length)
            {
                Console.Write($"");
                again = false;
            }
            else
            {
                Console.WriteLine("I'm sorry. I did not understand that. Please enter a number from 1 to 10.");

                again = true;
            }
        }

        private static bool NewStudent(ref bool oneMoreTime)
        {
            bool again;
            Console.WriteLine("Would you like to look up another student? Y/N");

            string userInputAgain = Console.ReadLine().ToLower();
            if (userInputAgain == "y" || userInputAgain == "yes")
            {
                Console.Clear();
                again = false;
                oneMoreTime = true;
            }
            else if (userInputAgain == "n" || userInputAgain == "no")
            {
                Console.Clear();
                Console.WriteLine("Thats fine. Have a wonderful day!");
                again = false;
                oneMoreTime = false;
            }
            else
            {

                Console.WriteLine("I'm Sorry. I did not understand.");
                again = true;
            }

            return again;
        }

        private static bool PersonInfo(string name, string food, string job)
        {
            bool again;
            Console.WriteLine($"Would you like to know {name}'s favorite food or pervious title? \n1:Food \n2:Title\n");
            string input = Console.ReadLine().ToLower();
            int.TryParse(input, out int userNum);

            if (input == "food" || userNum == 1)
            {
                Console.WriteLine($"{name}'s favorite food is {food}");
                again = false;
            }
            else if (input == "title" || userNum == 2)
            {
                Console.WriteLine($"{name}'s former title was {job}");
                again = false;
            }
            else
            {
                Console.WriteLine("Im sorry. I did not understand that");
                again = true;
            }

            return again;
        }
    }
}
