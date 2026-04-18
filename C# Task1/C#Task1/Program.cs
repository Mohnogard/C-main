using System;

class Program
{
    //Tasks (Required)

    // Task 1

    //static void myDetails(int age, string name)
    //{
    //    Console.WriteLine($"I am {age} and my name is {name}");
    //}

    //static void Main()
    //{
    //    myDetails(29, "Ahmad");
    //}


    /// ///////////////////////////////////////////////////////////////////

    // Task 2

    //static void Main()
    //{
    //    Console.Write("Enter a number:");
    //    string number = Console.ReadLine();
    //    int newNumber = Convert.ToInt32(number);
    //    if (newNumber%2==0)
    //    {
    //        Console.WriteLine("Number is even");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Number is odd");
    //    }
    //}


    /// ///////////////////////////////////////////////////////////////////


    // Task 3

    //static void Main()
    //{
    //    Console.Write("Enter your name:");
    //    string name = Console.ReadLine();
    //    {
    //        Console.WriteLine(name);
    //    }
    //}


    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    // Tasks 4 - 18 (If & Switch in C#)
    static void Main()
    {
        Console.Write("Do you want to work with switch tasks? (yes/no)");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            Console.Write("Which task do you want?");
            string taskNo = Console.ReadLine();
            int taskNumber = Convert.ToInt32(taskNo) - 3;
            Console.Write("Enter value(s) you want to work with:");

            switch (taskNumber)
            {
                case 1:
                    int newValue = int.Parse(Console.ReadLine());
                    if (newValue > 0)
                    {
                        Console.WriteLine("Number is positive");
                    }
                    else if (newValue < 0)
                    {
                        Console.WriteLine("Number is negative");
                    }
                    else
                    {
                        Console.WriteLine("Number is 0");
                    }

                    break;

                case 2:
                    int year = int.Parse(Console.ReadLine());

                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                        Console.WriteLine("Leap Year");
                    else
                        Console.WriteLine("Not a Leap Year");
                    break;

                case 3:
                    int marks = int.Parse(Console.ReadLine());

                    if (marks >= 50)
                        Console.WriteLine("Pass");
                    else
                        Console.WriteLine("Fail");
                    break;

                case 4:
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    if (num1 > num2)
                        Console.WriteLine($"Larger is {num1}");
                    else
                        Console.WriteLine($"Larger is {num2}");
                    break;

                case 5:
                    int num = int.Parse(Console.ReadLine());

                    if (num % 3 == 0 && num % 5 == 0)
                        Console.WriteLine("Divisible by 3 and 5");
                    else
                        Console.WriteLine("Not divisible by both");
                    break;

                case 6:
                    char ch = char.ToLower(Console.ReadLine()[0]);

                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        Console.WriteLine("Vowel");
                    else
                        Console.WriteLine("Consonant");
                    break;
                case 7:

                    int age = int.Parse(Console.ReadLine());

                    if (age < 13)
                        Console.WriteLine("Child");
                    else if (age < 20)
                        Console.WriteLine("Teenager");
                    else
                        Console.WriteLine("Adult");
                    break;
                case 8:
                    int day = int.Parse(Console.ReadLine());

                    switch (day)
                    {
                        case 1: Console.WriteLine("Sunday"); break;
                        case 2: Console.WriteLine("Monday"); break;
                        case 3: Console.WriteLine("Tuesday"); break;
                        case 4: Console.WriteLine("Wednesday"); break;
                        case 5: Console.WriteLine("Thursday"); break;
                        case 6: Console.WriteLine("Friday"); break;
                        case 7: Console.WriteLine("Saturday"); break;
                        default: Console.WriteLine("Invalid"); break;
                    }
                    break;

                case 9:
                    int month = int.Parse(Console.ReadLine());

                    switch (month)
                    {
                        case 1: Console.WriteLine("January"); break;
                        case 2: Console.WriteLine("February"); break;
                        case 3: Console.WriteLine("March"); break;
                        case 4: Console.WriteLine("April"); break;
                        case 5: Console.WriteLine("May"); break;
                        case 6: Console.WriteLine("June"); break;
                        case 7: Console.WriteLine("July"); break;
                        case 8: Console.WriteLine("August"); break;
                        case 9: Console.WriteLine("September"); break;
                        case 10: Console.WriteLine("October"); break;
                        case 11: Console.WriteLine("November"); break;
                        case 12: Console.WriteLine("December"); break;
                        default: Console.WriteLine("Invalid"); break;
                    }
                    break;
                case 10:
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    char op = Console.ReadLine()[0];

                    switch (op)
                    {
                        case '+': Console.WriteLine(a + b); break;
                        case '-': Console.WriteLine(a - b); break;
                        case '*': Console.WriteLine(a * b); break;
                        case '/': Console.WriteLine(b != 0 ? a / b : "Cannot divide by zero"); break;
                        default: Console.WriteLine("Invalid operator"); break;
                    }
                    break;
                case 11:

                    char grade = char.ToUpper(Console.ReadLine()[0]);

                    switch (grade)
                    {
                        case 'A': Console.WriteLine("Excellent"); break;
                        case 'B': Console.WriteLine("Good"); break;
                        case 'C': Console.WriteLine("Average"); break;
                        case 'D': Console.WriteLine("Below Average"); break;
                        case 'F': Console.WriteLine("Fail"); break;
                        default: Console.WriteLine("Invalid grade"); break;
                    }
                    break;
                case 12:

                    int Num = int.Parse(Console.ReadLine());

                    switch (Num)
                    {
                        case 1: Console.WriteLine("You chose 1"); break;
                        case 2: Console.WriteLine("You chose 2"); break;
                        case 3: Console.WriteLine("You chose 3"); break;
                        default: Console.WriteLine("Invalid"); break;
                    }
                    break;
                case 13:
                    int Number = int.Parse(Console.ReadLine());

                    switch (Number % 2)
                    {
                        case 0: Console.WriteLine("Even"); break;
                        case 1: Console.WriteLine("Odd"); break;
                    }
                    break;
                case 14:
                    string role = Console.ReadLine().ToLower();

                    switch (role)
                    {
                        case "admin": Console.WriteLine("Full access"); break;
                        case "user": Console.WriteLine("Limited access"); break;
                        case "guest": Console.WriteLine("Guest access"); break;
                        default: Console.WriteLine("Unknown role"); break;
                    }
                    break;

                case 15:

                    Console.WriteLine("1. Start");
                    Console.WriteLine("2. Settings");
                    Console.WriteLine("3. Exit");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Starting...");
                            break;

                        case 2:
                            Console.WriteLine("Opening settings...");
                            break;

                        case 3:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    break;
            }
        }

        else
        {
            Console.WriteLine("ok");
        }



        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // If Statements – Advanced  Questions Task 1

        Console.WriteLine("Working with employee:");
        string employee = Console.ReadLine();
        Console.WriteLine("Whose rating is:");
        string rating = Console.ReadLine();
        int ratings = int.Parse(rating);

        if (90 <= ratings && ratings <= 100)
        {
            Console.WriteLine($"{employee} performed Excellent, and gets a + 20% bonus");
        }
        else if (75 <= ratings && ratings < 90)
        {
            Console.WriteLine($"{employee} performed Very good, and gets a + 15% bonus");
        }
        else if (60 <= ratings && ratings < 75)
        {
            Console.WriteLine($"{employee} performed Good, and gets a + % bonus");
        }
        else if (ratings < 60 && ratings <= 0)
        {
            Console.WriteLine("no bonus.");
        }
        else
        {
            Console.WriteLine("ERROR");
        }


        /// ///////////////////////////////////////////////////////////////////

        // If Statements – Advanced  Questions Task 2

        Console.WriteLine("Let's check if you're eliggible, how high is your grade?");
        string GradePlaceholder = Console.ReadLine();
        Console.WriteLine("Do you have any special exceptions?");
        string SpecialPlaceholder = Console.ReadLine();
        int Grade = int.Parse(GradePlaceholder);
        bool Special = bool.Parse(SpecialPlaceholder);

        if (Grade >= 80 || Special)
        {
            Console.WriteLine("Welcome to uni");
        }
        else
        {
            Console.WriteLine("You're not eligible");
        }

        /// ///////////////////////////////////////////////////////////////////

        // If Statements – Advanced  Questions Task 3

        Console.WriteLine("Please enter package weight:");
        string WeightPh = Console.ReadLine();
        int Weight = int.Parse(WeightPh);

        if (Weight <= 1)
        {
            Console.WriteLine($"Cost is 5$");
        }
        else if (1 < Weight && Weight <= 5)
        {
            Console.WriteLine($"Cost is 10$");
        }
        else if (5 < Weight && Weight <= 10)
        {
            Console.WriteLine($"Cost is 20$");
        }
        else if (Weight < 10)
        {
            Console.WriteLine($"Cost is 50$ (Heavy Package!)");
        }

        /// ///////////////////////////////////////////////////////////////////

        // If Statements – Advanced  Questions Task 4

        string correctUsername = "admin";
        string correctPassword = "1234";

        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful");
                return; // exit program
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid credentials");
            }
        }

        Console.WriteLine("Account locked");

        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Switch Statements – Advanced Questions Task 1

        Console.Write("Choose item (1-4): ");
        int choices = int.Parse(Console.ReadLine());

        switch (choices)
        {
            case 1:
                Console.WriteLine("Burger - $5");
                break;
            case 2:
                Console.WriteLine("Pizza - $8");
                break;
            case 3:
                Console.WriteLine("Pasta - $7");
                break;
            case 4:
                Console.WriteLine("Salad - $4");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        /// ///////////////////////////////////////////////////////////////////

        // Switch Statements – Advanced Questions Task 2

        Console.Write("Enter grade: ");
        char Grade1 = char.ToUpper(Console.ReadLine()[0]);

        switch (Grade1)
        {
            case 'A': Console.WriteLine("Excellent"); break;
            case 'B': Console.WriteLine("Very Good"); break;
            case 'C': Console.WriteLine("Good"); break;
            case 'D': Console.WriteLine("Pass"); break;
            case 'F': Console.WriteLine("Fail"); break;
            default: Console.WriteLine("Invalid grade"); break;
        }


        /// ///////////////////////////////////////////////////////////////////

        // Switch Statements – Advanced Questions Task 3

        double balance = 1000;

        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");

        int choice1 = int.Parse(Console.ReadLine());

        switch (choice1)
        {
            case 1:
                Console.WriteLine($"Balance: {balance}");
                break;

            case 2:
                Console.Write("Enter amount: ");
                double deposit = double.Parse(Console.ReadLine());
                balance += deposit;
                Console.WriteLine($"New balance: {balance}");
                break;

            case 3:
                Console.Write("Enter amount: ");
                double withdraw = double.Parse(Console.ReadLine());

                if (withdraw <= balance)
                {
                    balance -= withdraw;
                    Console.WriteLine($"New balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
                break;

            case 4:
                Console.WriteLine("Goodbye");
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }


        // Switch Statements – Advanced Questions Task 4

        Console.Write("Enter first number: ");
        double Num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double Num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        int choices1 = int.Parse(Console.ReadLine());

        switch (choices1)
        {
            case 1:
                Console.WriteLine($"Result: {Num1 + Num2}");
                break;

            case 2:
                Console.WriteLine($"Result: {Num1 - Num2}");
                break;

            case 3:
                Console.WriteLine($"Result: {Num1 * Num2}");
                break;

            case 4:
                if (Num2 != 0)
                    Console.WriteLine($"Result: {Num1 / Num2}");
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

    }
}