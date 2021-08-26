using System;
using System.IO;
using System.Security.Cryptography;

namespace P1_2
{
    class Program
    {
        // This function reads the inputs from the command line
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

        // You can put your solution inside of this solve function
        private static double Solve(string plaintext, string ciphertext)
        {
            // Helpful code from the instructions:
            DateTime dt = DateTime.Now;
            TimeSpan ts = dt.Subtract(new DateTime(1970, 1, 1));
            // how to cast a TimeSpan to an int
            // int start = (int)ts.TotalMinutes;

            // string secretString = "";
            Random rng = new Random((int)ts.TotalMinutes);
            byte[] key = BitConverter.GetBytes(rng.NextDouble());
        
            // Console.WriteLine(Encrypt(key, secretString));

            // Hint: We are finding the seed that was used to make the key (and we only return the seed once we find the correct key that was used to encrypt the plaintext)
            // The weakness is that C#'s Random((int)ts.TotalMinutes)) function is pseudo-random. Basically this means if we know the seed (int)ts.TotalMinutes then we can build the same random sequence used to make the key

            return -1;
        }

        // The Encrypt function that your friend used
        private static string Encrypt(byte[] key, string secretString)
        {
            DESCryptoServiceProvider csp = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, csp.CreateEncryptor(key, key), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(secretString);
            sw.Flush();
            cs.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
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
            var solution = Solve(plaintext, ciphertext);

            // Output the solution to the autograder
            Console.WriteLine(solution);
        }
    }
}
