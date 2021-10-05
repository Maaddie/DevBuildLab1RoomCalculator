using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user to enter values for length and width and height
            //2. Get user input
            //3. Convert the input into a double for length and width and height
            //4. Run the formulas 
            //5. Print the result of the area
            //6. Print the result of the perimeter
            //7. Print the result of volume
            //8. Print the amount of carpet tiles needed
            //9. Print the amount of cans of paint needed
            //10. Get user input if they would like to continue. Loop if they do.

            string userAnswer = "Y";

           do
            {

               Console.WriteLine("Hello! This is your Room Calculator");
                Console.WriteLine("Please input the Length of the Classroom: ");

                string inputLength = Console.ReadLine();
                double length = double.Parse(inputLength);

                Console.WriteLine("Please input the Width of the Classroom: ");

                string inputWidth = Console.ReadLine();
                double width = double.Parse(inputWidth);

                Console.WriteLine("Please input the height of your Classroom: ");

                string inputHeight = Console.ReadLine();
                double height = double.Parse(inputHeight);

                double areaResult = length * width;

                Console.WriteLine("The area of your Classroom is: " + areaResult + " square feet");

                double perimeterResult = 2 * (length + width);

                Console.WriteLine("The perimeter of your Classroom is: " + perimeterResult);

                double volume = length * width * height;

                Console.WriteLine("The volume of your clasroom is " + volume);

                double carpetTiles = (areaResult / 5);

                Console.WriteLine("You will need " + carpetTiles + " carpet tiles for your Classroom.");

                double cansOfPaint = (2 * (height * width) + 2 * (height * length) + (areaResult)) / 5;

                Console.WriteLine("You will need " + cansOfPaint + " cans of paint for the Classroom.");
                
                Console.WriteLine("If you would like to continue measuring rooms, please Enter 'Y' ?");

                userAnswer = Console.ReadLine();

            }
            while (userAnswer == "Y" || userAnswer == "y");

            Console.WriteLine("If your answer is not 'Y' the Calculator will close.");


            //Review of yesterday's lab completed by Teacher

            //1) Prompt user for length and width and height
            //2) Get user input 3 times and store it
            //3) try to parse input into doubles
            //4) Calculate Area
            //5) Calculate Perimeter
            //6) Calculate Carpet tiles
            //7) Calculate Paint cans ( Both on the walls on the perimeter)
            //8) Figure if the user wishes to continue Y/N

           /* Console.WriteLine("Welcome to the GC Room Calculator");
            Console.WriteLine("Please input a length ");
            string inputLen = Console.ReadLine();

            Console.WriteLine("Please input a Width");
            string inputWid = Console.ReadLine();

            Console.WriteLine("Please input a Height");
            string inputHeight = Console.ReadLine();

            double length = double.Parse(inputLen);
            double width = double.Parse(inputWid);
            double height = double.Parse(inputHeight);

            double area = length * width;
            double volume = length * width * height;
            double perimeter = 2 * length + 2 * width;

            double carpetTiles = area / 5;
            double paintPerimeter = perimeter / 5;

            double paintWalls = (area + 2 * length * height + 2 * width * height) / 25;

            Console.WriteLine($"Length: {length}" );
            Console.WriteLine($"Width: {width}" );
            Console.WriteLine($"Height: {height}");
            Console.WriteLine();
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine();
            Console.WriteLine($"Carpet Tiles: {carpetTiles}");
            Console.WriteLine($"Perimeter Paint Cans: {paintPerimeter}");
            Console.WriteLine($"Paint Cans for Walls: {paintWalls}");

            bool askAgain = true;

            while (askAgain == true)

            Console.WriteLine();
            Console.WriteLine("Would you like to continue? Y/N");
            string answer = Console.WriteLine().ToLower();
            //Three possibilities to check for:
            //1) Y
            //2) N
            //3) Anything else

            if(answer == "y")
            {
                askAgain = false;
                goOn = true;

            }
            else if(answer == "n")
            {
                askAgain = false;
                goOn = false;
                Console.WriteLine("Good Bye");
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that ");
                Console.WriteLine("Let's try that again"); */ 
            }







        }
    }
}
