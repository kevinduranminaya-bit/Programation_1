try
{
    bool running = true;

    Console.WriteLine("<=== Student System ===>");

    while (running)
    {
        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Student Grades");
        Console.WriteLine("3. Exit");

        Console.WriteLine("Enter your choice: ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                {
                    bool calculatorRunning = true;

                    while (calculatorRunning)
                    {
                        Console.WriteLine("<=== Calculator ===>");
                        Console.WriteLine("1. Addition");
                        Console.WriteLine("2. Subtraction");
                        Console.WriteLine("3. Multiplication");
                        Console.WriteLine("4. Division");
                        Console.WriteLine("5. Back to Main Menu");

                        Console.WriteLine("Enter your choice: ");
                        int calculatorOption = Convert.ToInt32(Console.ReadLine());

                        switch (calculatorOption)
                        {
                            case 1:
                                decimal addition = 0m;
                                bool adding = true;

                                while (adding)
                                {
                                    Console.WriteLine("Enter a number to add: ");
                                    Console.WriteLine("Enter 0 to finish adding.");
                                    Console.WriteLine("Enter -1 to go back");

                                    decimal number = Convert.ToDecimal(Console.ReadLine());

                                    switch (number)
                                    {
                                        case 0:
                                            adding = false;
                                            break;
                                        case -1:
                                            adding = false;
                                            addition = 0m;
                                            break;
                                        default:
                                            addition += number;
                                            break;
                                    }

                                }

                                Console.WriteLine("Result: " + addition);
                                break;

                            case 2:
                                Console.WriteLine("Enter the first number: ");
                                decimal subtraction = Convert.ToDecimal(Console.ReadLine());

                                bool subtracting = true;
                                while (subtracting)
                                {
                                    Console.WriteLine("Enter a number to subtract: ");
                                    Console.WriteLine("Enter 0 to finish subtracting.");
                                    Console.WriteLine("Enter -1 to go back");
                                    decimal number = Convert.ToDecimal(Console.ReadLine());
                                    switch (number)
                                    {
                                        case 0:
                                            subtracting = false;
                                            break;
                                        case -1:
                                            subtracting = false;
                                            subtraction = 0m;
                                            break;
                                        default:
                                            subtraction -= number;
                                            break;
                                    }
                                }
                                Console.WriteLine("Result: " + subtraction);
                                break;
                            case 3:
                                decimal multiplication = 1m;
                                bool multiplying = true;
                                while (multiplying)
                                {
                                    Console.WriteLine("Enter a number to multiply: ");
                                    Console.WriteLine("Enter 1 to finish multiplying.");
                                    Console.WriteLine("Enter -1 to go back");
                                    decimal number = Convert.ToDecimal(Console.ReadLine());
                                    switch (number)
                                    {
                                        case 1:
                                            multiplying = false;
                                            break;
                                        case -1:
                                            multiplying = false;
                                            multiplication = 0m;
                                            break;
                                        default:
                                            multiplication *= number;
                                            break;
                                    }
                                }
                                Console.WriteLine("Result: " + multiplication);
                                break;
                            case 4:
                                Console.WriteLine("Enter the first number: ");
                                decimal division = Convert.ToDecimal(Console.ReadLine());
                                bool dividing = true;
                                while (dividing)
                                {
                                    Console.WriteLine("Enter a number to divide by: ");
                                    Console.WriteLine("Enter 1 to finish dividing.");
                                    Console.WriteLine("Enter -1 to go back");
                                    decimal number = Convert.ToDecimal(Console.ReadLine());
                                    switch (number)
                                    {
                                        case 1:
                                            dividing = false;
                                            break;
                                        case -1:
                                            dividing = false;
                                            division = 0m;
                                            break;
                                        default:
                                            if (number == 0)
                                            {
                                                Console.WriteLine("Cannot divide by zero.");
                                                continue;
                                            }
                                            division /= number;
                                            break;
                                    }
                                }
                                Console.WriteLine("Result: " + division);
                                break;
                            case 5:
                                calculatorRunning = false;
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                    }
                    break;
                }

            case 2:
                Console.WriteLine("<=== Grade System ===>");
                decimal number1 = 101;
                decimal number2 = 101;
                decimal number3 = 101;
                decimal number4 = 101;

                while (number1 > 100 || number1 < 0)
                {
                    Console.WriteLine("Enter the first grade (0-100): ");
                    number1 = Convert.ToDecimal(Console.ReadLine());
                }

                while (number2 > 100 || number2 < 0)
                {
                    Console.WriteLine("Enter the second grade (0-100): ");
                    number2 = Convert.ToDecimal(Console.ReadLine());
                }

                while (number3 > 100 || number3 < 0)
                {
                    Console.WriteLine("Enter the third grade (0-100): ");
                    number3 = Convert.ToDecimal(Console.ReadLine());
                }

                while (number4 > 100 || number4 < 0)
                {
                    Console.WriteLine("Enter the fourth grade (0-100): ");
                    number4 = Convert.ToDecimal(Console.ReadLine());
                }

                decimal average = (number1 + number2 + number3 + number4) / 4;
                Console.WriteLine("The average is: " + average);
                break;

            case 3:
                running = false;
                break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
