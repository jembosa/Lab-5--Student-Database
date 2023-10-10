namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tommy", "Ethan", "Alex", "Irving", "Kyle", "Michael" };
            string[] hometown = { "Detroit", "New York", "San Jose", "Columbus", "Canada", "Royal Oak" };
            string[] favfood = { "Culver's", "Steak", "Soup", "Salad", "Pasta", "Breadsticks" };
            //int x = 0;
            //while (x == 0)
            {
                while (true)

                {

                    Console.Write("Please enter student number (1 through " + names.Length + "): ");

                    int snumber = 0;
                    while (int.TryParse(Console.ReadLine(), out snumber) == false || snumber < 1 || snumber > names.Length)
                    {
                        Console.WriteLine("Invalid number, try 1 through " + names.Length + ".");
                    }


                    //x = 1;
                    int index = snumber - 1;

                    Console.WriteLine("Student Name: " + names[index]);

                    Console.WriteLine($"Learn more about {names[index]}  type 'Hometown' or 'Favorite food'");
                    string choice = Console.ReadLine();

                    if (choice.ToLower() == "hometown")
                    {
                        Console.WriteLine($"{names[index]} is from {hometown[index]}");
                    }
                    else if (choice.ToLower() == "favorite food")
                    {
                        Console.WriteLine($"{names[index]}'s favorite food is {favfood[index]}");
                    }
                    else
                    {
                        Console.WriteLine($"I don't know that about {names[index]}. Try 'Hometown' or 'Favorite food");
                    }




                    Console.Write("Would you like to learn about another student? Type 'y/n'");
                    string goagain = Console.ReadLine();

                    if (goagain != "y")
                    {
                        break;
                    }
                }
                //Console.Write("Would you like to learn about another student? Type 'y/n'");
                //string goagain = Console.ReadLine();
                //if (goagain != "y")
                //{
                //    break;
                //}


            }
        }
    }
}
