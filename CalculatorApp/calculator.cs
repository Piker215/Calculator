using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        a:
        Console.Clear();
        Console.WriteLine("   ____________              _____             ___               ____________                           ___                     _____        _____________  ____________        _______");
        Console.WriteLine("  /                         /    \\            |  |              /                   | |       | |      |  |                    /     \\           | |       /            \\      |       \\");
        Console.WriteLine(" /                         /      \\           |  |             /                    | |       | |      |  |                   /       \\          | |      /              \\     |        \\");
        Console.WriteLine("/                         /________\\          |  |            /                     | |       | |      |  |                  /_________\\         | |     /                \\    |________/  ");
        Console.WriteLine("\\                        /          \\         |  |            \\                     | |       | |      |  |                 /           \\        | |     \\                /    |        \\ ");
        Console.WriteLine(" \\                      /            \\        |  |_______      \\                    | |       | |      |  |_______         /             \\       | |      \\              /     |         \\");
        Console.WriteLine("  \\_____________       /              \\       |__________|      \\_____________      |_|_______|_|      |___________|      /               \\      |_|       \\____________/      |          \\");
        Console.WriteLine("Choose which operation you'd like to perform:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Power");
        Console.WriteLine("6. Root");
        Console.WriteLine("7. Equation");
        Console.WriteLine("8. Logarithm (base 10 and base e)");
        Console.WriteLine("9. Matrix");
        string operation = Console.ReadLine();
        if (operation == "1")
        {
            Console.WriteLine("What numbers would you like to add?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 + num2;
            Console.Clear();
            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        else if (operation == "2")
        {
            Console.WriteLine("What numbers would you like to subtract?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 - num2;
            Console.Clear();
            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        else if (operation == "3")
        {
            Console.WriteLine("What numbers would you like to multiply?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 * num2;
            Console.Clear();
            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        else if (operation == "4")
        {
            Console.WriteLine("What numbers would you like to divide?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                Console.Clear();
                double result = num1 / num2;
                Console.WriteLine(result);
                Console.WriteLine("Press any key to continue...");
            }
            Console.ReadKey();
            Console.Clear();

        }
        else if (operation == "5")
        {
            Console.WriteLine("What power would you like to raise it to?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What number would you like to raise to that power?");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(num2, num1);
            Console.Clear();
            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        else if (operation == "6")
        {
            Console.WriteLine("What root are you trying to find?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What number would you like to find the root of?");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(num2, 1.0 / num1);
            if (num1 != 0)
            {
                Console.Clear();
                Console.WriteLine(result);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error: Root degree cannot be zero.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else if (operation == "7")
        {
            Console.WriteLine("What type of equation are you trying to solve?");
            Console.WriteLine("1. Linear (ax + b = c)");
            Console.WriteLine("2. Quadratic (ax^2 + bx + c = 0)");
            string choice = Console.ReadKey().KeyChar.ToString();
            Console.Clear();
            if (choice == "1")
            {
                Console.WriteLine("Enter the left side of the equation (in order!):");
                string leftEquation = Console.ReadLine();
                Console.WriteLine("Enter the right side of the equation:");
                string rightEquation = Console.ReadLine();
                double solution = SolveLinearEquation(leftEquation, rightEquation);
                Console.WriteLine($"The solution is: {solution}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter the left side of the equation (in order!(without power)):");
                string leftEquation = Console.ReadLine();
                Console.WriteLine("Enter the right side of the equation:");
                string rightEquation = Console.ReadLine();
                Console.WriteLine("What would you like to solve your equation?");
                Console.WriteLine("1.Value of x");
                Console.WriteLine("2. Delta");
                string subchoice = Console.ReadKey().KeyChar.ToString();
                Console.Clear();
                double solution = SolveSquareEquation(leftEquation, rightEquation, Convert.ToInt32(subchoice));
                Console.WriteLine($"The solution is: {solution}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        }
        else if (operation == "8")
        {
            Console.WriteLine("What number would you like to find the logarithm of?");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose the base of the logarithm:");
            Console.WriteLine("1. Base 10");
            Console.WriteLine("2. Base e (natural logarithm)");
            Console.WriteLine("3. Random logarithm");
            string baseChoice = Console.ReadLine();
            if (baseChoice == "1")
            {
                Console.Clear();
                double result = Math.Log10(num);
                Console.WriteLine($"The logarithm base of 10 of {num} is: {result}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (baseChoice == "2")
            {
                double result = Math.Log(num);
                Console.Clear();
                Console.WriteLine($"The natural algorithm (base e) of {num} is : {result}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (baseChoice == "3")
            {
                Console.WriteLine("Enter the base of the logarithm:");
                double baseNum = Convert.ToDouble(Console.ReadLine());
                double result = Math.Log(num, baseNum);
                Console.Clear();
                Console.WriteLine($"The logarithm base of {baseNum} of {num} is: {result}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else if (operation == "9")
        {
            Console.WriteLine("Add the top left number of the matrix:");
            double a11 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add the top right number of the matrix:");
            double a12 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add the bottom left number of the matrix:");
            double a21 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Add the bottom right number of the matrix:");
            double a22 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("The matrix you have created is:");
            Console.WriteLine($"| {a11} {a12} |");
            Console.WriteLine($"| {a21} {a22} |");
            Console.WriteLine("The answers for the matrix are:");
            double determinant = a11 * a22 - a12 * a21;
            Console.WriteLine($"Determinant: {determinant}");
            double determinantY = a21 * a12 - a22 * a11;
            Console.WriteLine($"Determinant Y: {determinantY}");
            double determinantX = a11 * a22 - a12 * a21;
            Console.WriteLine($"Determinant X: {determinantX}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid operation selected.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        goto a;

        double SolveLinearEquation(string left, string right)
        {
            if (left.Contains("x") && right.All(char.IsDigit))
            {
                left = left.Replace(" ", "");
                right = right.Replace(" ", "");
                int xIndex = left.IndexOf('x');
                string coefficientStr = left.Substring(0, xIndex);
                double leftp = Convert.ToDouble(coefficientStr);
                double rightp = Convert.ToDouble(right);
                char signLeft = left.Substring(xIndex + 1).FirstOrDefault();
                double leftc = left.Substring(xIndex + 2).All(char.IsDigit) ? Convert.ToDouble(left.Substring(xIndex + 2)) : 0;

                if (leftp == 0)
                {
                    throw new ArgumentException("Coefficient of x cannot be zero.");
                }
                else if (signLeft == '+')
                {
                    double x = (rightp - leftc) / leftp;
                    return x;
                }
                else if (signLeft == '-')
                {
                    double x = (rightp + leftc) / leftp;
                    return x;
                }
            }
            Console.WriteLine("Wrongly made function");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            return 0;


        }
        double SolveSquareEquation(string left, string right, int type)
        {
            if (left.Contains("x") && right.All(char.IsDigit))
            {
                left = left.Replace(" ", "");
                right = right.Replace(" ", "");
                int xIndex = left.IndexOf('x');
                int x2index = left.IndexOf('x', xIndex + 2);
                double leftc = left.Substring(x2index + 1).All(char.IsDigit) ? Convert.ToDouble(left.Substring(x2index + 2)) : 0;
                string coefficientSqr = left.Substring(0, xIndex);
                double leftp = Convert.ToDouble(coefficientSqr);
                double rightp = Convert.ToDouble(right);

                double left2p = Convert.ToDouble(left.Substring(xIndex + 2));
                
                if (leftp == 0)
                {
                    throw new ArgumentException("Coefficient of x cannot be zero.");
                }
                else if (left2p != 0)
                {
                    if (type == 1)
                    {
                        double delta = Math.Sqrt(Math.Pow(left2p, 2) - 4 * leftp * leftc);
                        double x1 = (-left2p + delta) / (2 * leftp);
                        double x2 = (-left2p - delta) / (2 * leftp);
                        Console.WriteLine("Delta is equal: " + delta);
                        Console.WriteLine($"The two solutions are: x1 = {x1}, x2 = {x2}");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        return 0;
                    }
                    else if (type == 2)
                    {
                    }
                }
                }
                    return 0;
            }



        }
    }