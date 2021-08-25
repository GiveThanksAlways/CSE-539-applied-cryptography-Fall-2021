using System;

namespace inputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables
            string input_1, input_2, input_3;
            // args is an array of strings that hold commandline inputs after the "dotnet run" command
            // inputs are seperated by spaces. This example will assume 3 inputs are provided
            // Need to check that 3 inputs were give in this example or else we will get an out of bound error on the array
            if(args.Length == 3){
                input_1 = args[0];
                input_2 = args[1];
                input_3 = args[2];
                // Now print the input values back to the command line for the example
                Console.WriteLine(String.Format("First input: {0}",input_1));
                Console.WriteLine(String.Format("Second input: {0}",input_2));
                Console.WriteLine(String.Format("Third input: {0}",input_3));
            }else{
                Console.WriteLine("Either not enough inputs or too many inputs");
            }

        }
    }
}
