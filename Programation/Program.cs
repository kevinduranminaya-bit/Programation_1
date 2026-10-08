try
{
    List<decimal> typedNumbers = new List<decimal>();
    bool running = true;

    Console.WriteLine("<=== STUDENT SYSTEM ===>");

    while (running)
    {
        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Student Grades");
        Console.WriteLine("3. Close");
        Console.Write("Enter an option: ");
        int option = Convert.ToInt32(Console.ReadLine());

        decimal average = 0m;
        switch (option)
        {
            case 1:
                Console.WriteLine("<=== CALCULATOR ===>");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Back");
                Console.Write("Enter an option: ");
                int calcOption = Convert.ToInt32(Console.ReadLine());

                switch (calcOption)
                {
                    case 1:
                        Console.WriteLine("Enter the first number: ");
                        decimal num1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        decimal num2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Result: " + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("Enter the first number: ");
                        num1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        num2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Result: " + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine("Enter the first number: ");
                        num1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        num2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Result: " + (num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("Enter the first number: ");
                        num1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        num2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Result: " + (num1 / num2));
                        break;

                    case 5:
                        break;
                }
                break;
            case 2:
                Console.WriteLine("<=== STUDENT GRADES ===>");
                Console.WriteLine("Enter the first grade: ");
                decimal grade1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the second grade: ");
                decimal grade2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the third grade: ");
                decimal grade3 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the fourth grade: ");
                decimal grade4 = Convert.ToDecimal(Console.ReadLine());
                average = (grade1 + grade2 + grade3 + grade4) / 4;
                Console.WriteLine("Average: " + average);
                string result = average >= 70m ? "Passed" : "Failed";
                Console.WriteLine("The result is: " + result);
                break;

            case 3:
                running = false;
                Console.WriteLine("Closing the program...");
                break;
        }
    }

}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}