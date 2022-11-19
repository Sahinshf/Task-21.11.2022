namespace Task_21_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            calculator(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
        }
        
        static void calculator(double num1 , double num2 , string z)
        {
            if( z == "+" )
            {
                Console.WriteLine(num1+num2);
            }
            else if (z == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (z == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (z == "/")
            {
                double result = num1 / num2;
                Console.WriteLine(result);
            }
        }
    }
}