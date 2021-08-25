using System;
using System.IO;
using System.Security.Cryptography;

namespace P1_2
{
    class Program
    {
        public static Tuple<string,string> getInputFromCommandLine(string[] args)
        {
            // initialize variables
            string input_1="", input_2="";
            // args is an array of strings that hold commandline inputs after the "dotnet run" command
            // inputs are seperated by spaces. This example will assume 3 inputs are provided
            // Need to check that 3 inputs were give in this example or else we will get an out of bound error on the array
            if(args.Length == 2){
                input_1 = args[0];
                input_2 = args[1];
            }else{
                Console.WriteLine("Either not enough inputs or too many inputs");
            }
            return Tuple.Create(input_1, input_2);
        }

        static void Main(string[] args)
        {
            // string plaintext = "Hello World";
            // string ciphertext = "RgdIKNgHn2Wg7jXwAykTlA==";
            // dotnet run "Hello World" "RgdIKNgHn2Wg7jXwAykTlA=="

            // string plaintext = args[0];
            // string ciphertext = args[1];
            Tuple<string, string> commandlineInputs = getInputFromCommandLine(args);
            string plaintext = commandlineInputs.Item1;
            string ciphertext = commandlineInputs.Item2;

            // TODO: Code the solution
            // var solution = Solve(plaintext, ciphertext);

            // Output the solution to the autograder
            // Console.WriteLine(solution);
        }
    }
}
