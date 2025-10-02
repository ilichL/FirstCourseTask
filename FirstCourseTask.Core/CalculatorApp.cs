using FirstCourseTask.Domain;

namespace FirstCourseTask
{
    public class CalculatorApp
    {
        private readonly IInputService _inputService;
        private readonly ICalculator _calculator;

        public CalculatorApp(IInputService inputService, ICalculator calculator)
        {
            _inputService = inputService;
            _calculator = calculator;
        }

        public void Run()
        {
            bool isWork = true;

            while (isWork)
            {
                double firstNumber = _inputService.GetValidNumber("Enter first number");
                string operation = _inputService.GetValidOperation();
                double secondNumber = _inputService.GetValidNumber("Enter second number");

                var result = _calculator.Calculate(firstNumber, secondNumber, operation);

                if (result is null)
                {
                    Console.WriteLine("Calculator is broken. I'm so sorry");
                }
                else
                {
                    Console.WriteLine($"Result is {result}");
                }

                isWork = _inputService.ShouldContinue();
            }
        }
    }
}