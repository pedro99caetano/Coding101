Console.WriteLine("OPTIONS");
Console.WriteLine("1 - The application receives four numbers and see which one is the highest. The result must be returned;");
Console.WriteLine("2 - The application receives two number a see which has the highest result of the division of one from the other. The result must be returned;");
Console.WriteLine("3 - The application receives four number a see which is the lowest after beening divided by the remaining. The result must be returned;");
Console.WriteLine("4 - The application receives two number and divides them. The result must be returned, with two decimal places;");
Console.WriteLine("5 - The application receives two number, calculates the multiplication and return the word “Bizz”when even and “Buzz” when odd;");
Console.WriteLine("6 - The application that receives two number and one operator option and executes the calculation. The result must be returned.");
Console.WriteLine();
Console.Write("Please select your option: ");

int option = int.Parse(Console.ReadLine());

while (true)
{
    switch (option)
    {
        case 1:
            {
                Console.WriteLine();
                Console.WriteLine("Please insert first variable");
                int firstVar = int.Parse(Console.ReadLine());
                Console.WriteLine("Please insert second variable");
                int secondVar = int.Parse(Console.ReadLine());
                Console.WriteLine("Please insert third variable");
                int thirdVar = int.Parse(Console.ReadLine());
                Console.WriteLine("Please insert fourth variable");
                int fourthVar = int.Parse(Console.ReadLine());

                // Find the highest number
                int maxNum = 0;
                if (firstVar > secondVar)
                {
                    maxNum = firstVar;
                }
                else
                {
                    maxNum = secondVar;
                }
                if (thirdVar > maxNum)
                {
                    maxNum = thirdVar;
                }
                if (fourthVar > maxNum)
                {
                    maxNum = fourthVar;
                }
                Console.WriteLine("The highiest number is: {0}", maxNum);

                //// Prompt user to run option again
                Console.WriteLine();
                Console.WriteLine("Would you like to run this option again? (Y/N)");
                string runAgain1 = Console.ReadLine().ToUpper();
                if (runAgain1 != "Y")
                {
                    break;
                }
                else
                { 
                    continue;
                }
            }
            break;

        
        case 2:
            {
                Console.WriteLine();
                Console.Write("Please insert first variable: ");
                int fifthVar = int.Parse(Console.ReadLine());
                Console.Write("Please insert second variable: ");
                int sixthVar = int.Parse(Console.ReadLine());

                int firstDiv = fifthVar / sixthVar;
                int secondDiv = sixthVar / fifthVar;

                int maxDiv = 0;
                if (firstDiv > secondDiv)
                {
                    maxDiv = firstDiv;
                }
                else
                {
                    maxDiv = secondDiv;
                }

                Console.WriteLine("The highiest division result is: {0}", maxDiv);

                //// Prompt user to run option again
                Console.WriteLine();
                Console.WriteLine("Would you like to run this option again? (Y/N)");
                string runAgain2 = Console.ReadLine().ToUpper();
                if (runAgain2 != "Y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            break;


        case 3:
            {
                Console.WriteLine();
                Console.Write("Please insert first variable: ");
                float firstVar = float.Parse(Console.ReadLine());
                Console.Write("Please insert second variable: ");
                float secondVar = float.Parse(Console.ReadLine());
                Console.Write("Please insert third variable: ");
                float thirdVar = float.Parse(Console.ReadLine());
                Console.Write("Please insert fourth variable: ");
                float fourthVar = float.Parse(Console.ReadLine());

                float firstDiv = (secondVar + thirdVar + fourthVar) / firstVar;
                Console.WriteLine("The sum of the remaining three numbers divided by the first variable is: " + firstDiv);
                float secondDiv = (firstVar + thirdVar + fourthVar) / secondVar;
                Console.WriteLine("The sum of the remaining three numbers divided by the second variable is: " + secondDiv);
                float thirdDiv = (firstVar + secondVar + fourthVar) / thirdVar;
                Console.WriteLine("The sum of the remaining three numbers divided by the third variable is: " + thirdDiv);
                float fourthDiv = (firstVar + secondVar + thirdVar) / fourthVar;
                Console.WriteLine("The sum of the remaining three numbers divided by the fourth variable is: " + fourthDiv);

                float minNum = 0;
                if (firstDiv < secondDiv)
                {
                    minNum = firstDiv;
                }
                else
                {
                    minNum = secondDiv;
                }
                if (thirdDiv < minNum)
                {
                    minNum = thirdDiv;
                }
                if (fourthDiv < minNum)
                {
                    minNum = fourthDiv;
                }
                Console.WriteLine("The lowest result is: {0}", minNum);

                //// Prompt user to run option again
                Console.WriteLine();
                Console.WriteLine("Would you like to run this option again? (Y/N)");
                string runAgain3 = Console.ReadLine().ToUpper();
                if (runAgain3 != "Y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            break;


        case 4:
            {
                Console.WriteLine();
                Console.Write("Please insert first variable: ");
                double seventhVar = double.Parse(Console.ReadLine());
                Console.Write("Please insert second variable: ");
                double eighthVar = double.Parse(Console.ReadLine());

                double seventhDiv = seventhVar / eighthVar;
                string div1 = $"{seventhDiv:f2}";
                Console.WriteLine("The division of {0} by {1} is: " + div1, seventhVar, eighthVar);

                double eighthDiv = eighthVar / seventhVar;
                string div2 = $"{eighthDiv:f2}";
                Console.WriteLine("The division of {1} by {0} is: " + div2, seventhVar, eighthVar);

                //// Prompt user to run option again
                Console.WriteLine();
                Console.WriteLine("Would you like to run this option again? (Y/N)");
                string runAgain4 = Console.ReadLine().ToUpper();
                if (runAgain4 != "Y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            break;


        case 5:
            {
                Console.WriteLine();
                Console.Write("Please insert first variable: ");
                double ninethVar = double.Parse(Console.ReadLine());
                Console.Write("Please insert second variable: ");
                double tenthVar = double.Parse(Console.ReadLine());

                double oddEven = (ninethVar * tenthVar) % 2;
                if (oddEven == 0)
                    Console.WriteLine("Bizz");
                else
                    Console.WriteLine("Buzz");

                //// Prompt user to run option again
                Console.WriteLine();
                Console.WriteLine("Would you like to run this option again? (Y/N)");
                string runAgain5 = Console.ReadLine().ToUpper();
                if (runAgain5 != "Y")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            break;


        case 6:
            {
                Console.WriteLine();
                Console.Write("Please insert first variable: ");
                double firstVar = double.Parse(Console.ReadLine());
                Console.Write("Please insert second variable: ");
                double secondVar = double.Parse(Console.ReadLine());
                Console.WriteLine("Please select an operation name: ");
                Console.WriteLine("SUM");
                Console.WriteLine("SUB");
                Console.WriteLine("MLT");
                Console.WriteLine("DIV");
                string optionTwo = Console.ReadLine().ToLower();

                switch (optionTwo)
                {
                    case "sum":
                        Console.WriteLine(firstVar + secondVar);
                        break;
                    case "sub":
                        Console.WriteLine(firstVar - secondVar);
                        break;
                    case "mlt":
                        Console.WriteLine(firstVar * secondVar);
                        break;
                    case "div":
                        Console.WriteLine(firstVar / secondVar);
                        break;
                }
            }
            break;

        default:
            {
                Console.WriteLine("Please select a valid option");
            }
            break;

            //// Prompt user to run option again
            Console.WriteLine();
            Console.WriteLine("Would you like to run this option again? (Y/N)");
            string runAgain6 = Console.ReadLine().ToUpper();
            if (runAgain6 != "Y")
            {
                break;
            }
            else
            {
                continue;
            }
    }
    // Prompt user to choose another option or exit
    Console.WriteLine();
    Console.WriteLine("Please select another option or enter any other key to exit: ");
    option = int.Parse(Console.ReadLine());
}
