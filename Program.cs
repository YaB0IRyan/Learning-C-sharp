//Ryan Scott (https://github.com/YaBoiRS)
//Learning C#
//Created 13/09/2021

//This program is for learning the basics of C#

using System;

namespace Learning_C_sharp {
    class Program {
        static void Main(string[] args) {
            string dashLine = "----------------------------------------------\n";
            Console.WriteLine("Hello, welcome to the program, please press enter to continue"); //Calls the WriteLine method from console class and writes the contents of the ("") to the console.
            Console.ReadKey();//Calls the ReadKey method from console class and pauses the execution to wait for the user to press an key.
            Console.WriteLine(dashLine);

            //Below shows initialisation of variables
            //variables are initialised like so: Datatype variable_name.

            int num1; //In this example, Datatype is int(integer), and variable_name is num1, so essentially we are saying that the variable num1 will contain integer data.
            int num2 = 4; //Here we are doing the same, but we are then populating the variable with data.
            int num3 = num2; //Here we are again populating the variable with data, but this time instead of giving data directly, we are using data from another variable.

            string introMessage = "Welcome to the basic variable section of the program"; //Here we are declaring a variable and populating it again, only this time we are using text instrad of numbers, this is known as a string.
            int x = 7;
            int y = 13;
            int answer;

            Console.WriteLine(introMessage); //Here we are writing a line to the console, but instead of giving the data on the line we are using the stored data from the previous variable
            Console.WriteLine("The value of x is: " + x + "\nThe value of y is: " + y); //The " + x" allows us to print the value of the variable x after the contents of the "". Also the \n starts a new line, allowing to break up lines of text being brinted without writing a new Console.WriteLine command.
            Console.WriteLine("\nWith theese numbers we can preform multiple actions, like: \n");

            //adding the numbers
            answer = x + y;
            Console.WriteLine("x + y is - " + answer);

            //subtracting the numbers
            answer = x - y;
            Console.WriteLine("\nx - y is - " + answer);

            //multiplying trhe numbers
            answer = x * y;
            Console.WriteLine("\nx - y is - " + answer);

            //dividing the numbers
            double answer2; //Here we have to use a double instead of an integer, this is because an integer can only be a whole number, whereas doubles can have a decimal place
            answer2 = (double)x / (double)y;
            Console.WriteLine("\nx - y is - " + answer2);

            //increace x by 1
            x++;
            Console.WriteLine("\nWe can increment x by 1, making x = " + x);

            //increace x by 1
            x--;
            Console.WriteLine("\nWe can decrement x by 1, making x = " + x + " again");


            //square x
            answer2 = Math.Pow(x, 2);
            Console.WriteLine("\nx^2 = " + answer2);

            //calculate the square root of answer2 (49)
            Console.WriteLine("\nthe square root of " + answer2 + " = " + Math.Sqrt(answer2));

            Console.WriteLine(dashLine);

        }
    }
}
