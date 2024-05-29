namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Calculator App:");
            Console.WriteLine("Please enter your first number:");
            double num1 = NumValidation();
            Console.WriteLine("Please enter your second number:");
            double num2 = NumValidation();
            Console.WriteLine("What type of operation would you like to do");

            double sum = MathOperations(num1, num2);
            Console.Clear();
            Console.WriteLine($"The result is {sum}");
            Console.WriteLine();
            Console.WriteLine("Thank you for using the calculator program!");
        }

        static double NumValidation()
        {
            double num1;
            string text = Console.ReadLine();
            while (!double.TryParse(text, out num1))
            {
                Console.WriteLine("Please enter integer value");
                text = Console.ReadLine();
            }
            return num1;
        }
        static double MathOperations(double num1, double num2)
        {
            while (true)
            {
                Console.WriteLine("Please enter: a or + for addition, - or s for subtraction, * or m for multiplication, / or d for division ");
                string operation = Console.ReadLine();

                if (operation == "+" || operation == "a")
                    return num1 + num2;
                else if (operation == "-" || operation == "s")
                    return num1 - num2;
                else if (operation == "*" || operation == "m")
                    return num1 * num2;
                else if (operation == "/" || operation == "d")
                    return num1 / num2;
                else
                {
                    Console.WriteLine("Enter the proper operation");
                    Console.WriteLine();
                }
            }

        }
    }
}
