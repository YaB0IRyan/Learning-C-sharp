//Ryan Scott (https://github.com/YaBoiRS)
//Learning C#
//Created 13/09/2021

//This program is for learning the basics of C#

using System;

namespace Learning_C_sharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, this is an example of text being printed, please press enter to continue"); //Calls the WriteLine method from console class and writes the contents of the ("") to the console.
            Console.ReadKey();//Calls the ReadKey method from console class and pauses the execution to wait for the user to press an key.

            //Below shows initialisation of variables
            //variables are initialised like so: Datatype variable_name.

            int num1; //In this example, Datatype is int(integer), and variable_name is num1, so essentially we are saying that the variable num1 will contain integer data.
            int num2 = 4; //Here we are doing the same, but we are then populating the variable with data.
            int num3 = num2; //Here we are again populating the variable with data, but this time instead of giving data directly, we are using data from another variable.
            
        }
    }
}
