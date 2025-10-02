using FirstCourseTask.Domain;

namespace FirstCourseTask.Infrastructure
{
    public class ConsoleInputService : IInputService
    {
        public double GetValidNumber(string prompt)
        {
            Console.WriteLine(prompt);

            while (true)
            {
                string number = Console.ReadLine();
                if (double.TryParse(number, out double normalizedNumber))
                {
                    return normalizedNumber;
                }
                Console.WriteLine("Your number is not correct. Please try again");
            }
        }

        public string GetValidOperation()
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

        public bool ShouldContinue()
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
    }
}