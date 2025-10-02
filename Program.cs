namespace FirstCourseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Enter first number");
                string firstNumber = Console.ReadLine();
                double firstNormalizedNumber = calculator.ReturnNormalizedNumber(firstNumber);

                string operation = calculator.OperationCheck();

                Console.WriteLine("Enter second number");
                string secondNumber = Console.ReadLine();
                double secondNormalizedNumber = calculator.ReturnNormalizedNumber(secondNumber);

                var result = calculator.Result(firstNormalizedNumber, secondNormalizedNumber, operation);

                if (result is null)
                {
                    Console.WriteLine("Calculator is broken. I'm so sorry");
                }
                else
                {
                    Console.WriteLine($"Result is {result}");
                }

                isWork = calculator.IsContinue();
            }
        }
    }
}