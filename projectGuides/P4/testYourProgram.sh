#!/bin/sh

# Instead of having to copy/paste the commented command below, you can just run this script from the command line ./testYourProgram.ps1
# dotnet run 254 1223 251 1339 66536047120374145538916787981868004206438539248910734713495276883724693574434582104900978079701174539167102706725422582788481727619546235440508214694579  1756026041

# example input given in the instructions (all numbers are base 10)
p_e=254
p_c=1223
q_e=251
q_c=1339
# when stored in a variable in a .ps1 script, you need to put "" around the number if it is really big
# at the end of the day, the program reads in everything as a string from the commandline, so you have parse the input regardless
# helpful parsing functions: Int32.Parse(...) BigInteger.Parse(...)
CipherText="66536047120374145538916787981868004206438539248910734713495276883724693574434582104900978079701174539167102706725422582788481727619546235440508214694579"
PlaintText="1756026041"

# This line will run the P4 example
dotnet run $p_e $p_c $q_e $q_c $CipherText $PlaintText


