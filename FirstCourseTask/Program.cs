
using FirstCourseTask.Infrastructure;
using FirstCourseTask.Domain;

namespace FirstCourseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInputService inputService = new ConsoleInputService();
            ICalculator calculator = new Calculator();
            var app = new CalculatorApp(inputService, calculator);

            app.Run();
        }
    }
}