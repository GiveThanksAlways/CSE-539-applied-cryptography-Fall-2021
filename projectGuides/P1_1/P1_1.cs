using System;
using System.IO;
using System.Collections;

namespace P1_1
{
    class Program
    {
        public static byte[] Solve(byte[] inputBytes, byte[] bmpBytes)
        {
            // Put your code in here
            byte[] exampleByteArray = new byte[bmpBytes.Length];
            return exampleByteArray;
        }

        public static string getInputFromCommandLine(string[] args)
        {
            // get the input from the command line
            string input = "";
            if (args.Length == 1)
            {
                input = args[0]; // Gets the first string after the 'dotnet run' command
            }
            else
            {
                Console.WriteLine("Not enough or too many inputs provided after 'dotnet run' ");
            }
            return input;
        }

        static void Main(string[] args)
        {
            // below is the example command of how to run your program
            // dotnet run "B1 FF FF CC 98 80 09 EA 04 48 7E C9"

            // bmpBytes is defined in the instructions (I put it here to save you time)
            byte[] bmpBytes = new byte[]
            {
                0x42,0x4D,0x4C,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x1A,0x00,0x00,0x00,0x0C,0x00,
                0x00,0x00,0x04,0x00,0x04,0x00,0x01,0x00,0x18,0x00,
                0x00,0x00,0xFF,
                0xFF,0xFF,0xFF,
                0x00,0x00,0xFF,
                0xFF,0xFF,0xFF,
                0xFF,0xFF,0xFF,
                0x00,0x00,0x00,
                0xFF,0xFF,0xFF,
                0x00,0x00,0x00,
                0xFF,0x00,0x00,
                0xFF,0xFF,0xFF,
                0xFF,0x00,0x00,
                0xFF,0xFF,0xFF,
                0xFF,0xFF,0xFF,
                0x00,0x00,0x00,
                0xFF,0xFF,0xFF,
                0x00,0x00,0x00
            };

            // get the input from the command line
            string input = getInputFromCommandLine(args);

        
            // TODO: Convert input string to an array of bytes (inputBytes)
            // This is an example of how to convert a string such as "F8" to a byte. (base 16 because F8 is Hexadecimal)
            Convert.ToByte("F8", 16);

            // run the code to find the solution
            byte[] solution = Solve(inputBytes, bmpBytes); // you can put your code in the solve function

            // Print the solution for the autograder to see
            Console.WriteLine(BitConverter.ToString(solution).Replace("-", " ")); // This line prints the output in the correct format for the autograder
        }

        // You can use this function to save a .bmp file to help you debug/ see what is going on. This function is not needed but may be useful to help visualize things
        public static void WriteToBMPFile(byte[] bmpBytes)
        {
            // This will get the current PROJECT directory (P1_1)
            string projectDirectory = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            System.IO.File.WriteAllBytes(projectDirectory + "/example.bmp", bmpBytes);
        }

    }
}
