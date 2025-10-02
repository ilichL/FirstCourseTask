namespace FirstCourseTask
{
    internal class Program
    {
        public static double ReturnNormalizedNumber(string number)
        {
            double normalizedNumber = 0;
            while (!double.TryParse(number, out normalizedNumber))
            {
                Console.WriteLine("Your number is not correct. Please try again");
                number = Console.ReadLine();
            }
            return normalizedNumber;
        }

        public static string OperationCheck()
        {
            while (true)
            {
                Console.WriteLine("Choose arithmetic operation \n" +
                    "1(+)\n" +
                    "2(-)\n" +
                    "3(*)\n" +
                    "4(/)");
                string operation = Console.ReadLine();

                if (operation == "1" || operation == "2" || operation == "3" || operation == "4")
                {
                    return operation;
                }

                Console.WriteLine("The operation you selected does not exist. Please try again");
            }
        }

        public static double? Result(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "1":
                    return firstNumber + secondNumber;
                case "2":
                    return firstNumber - secondNumber;
                case "3":
                    return firstNumber * secondNumber;
                case "4":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error! Division by zero!");
                        return null;
                    }
                    return firstNumber / secondNumber;
                default:
                    Console.WriteLine("You broke the calculator, congratulations");
                    return null;
            }
        }

        public static bool IsContinue() // ← исправил кириллическую "С"
        {
            while (true)
            {
                Console.WriteLine("Do you want to continue?" +
                    "1(Yes) 2(No)");
                string isContinue = Console.ReadLine();
                if (isContinue == "1")
                {
                    return true;
                }
                if (isContinue == "2")
                {
                    return false;
                }
                Console.WriteLine("Your number is not correct. Please try again");
            }
        }

        static void Main(string[] args)
        {
            bool isWork = true;
            while (isWork)
            {
                Console.WriteLine("Enter first number");
                string firstNumber = Console.ReadLine();
                double firstNormalizedNumber = ReturnNormalizedNumber(firstNumber);

                string operation = OperationCheck();

                Console.WriteLine("Enter second number");
                string secondNumber = Console.ReadLine();
                double secondNormalizedNumber = ReturnNormalizedNumber(secondNumber);

                var result = Result(firstNormalizedNumber, secondNormalizedNumber, operation);

                if (result is null)
                {
                    Console.WriteLine("Calculator is broken. I'm so sorry");
                }
                else
                {
                    Console.WriteLine($"Result is {result}");
                }

                isWork = IsContinue();
            }
        }
    }
}