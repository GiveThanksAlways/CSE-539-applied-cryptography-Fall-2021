#!/bin/sh

# example input given in the instructions
IV="A2 2D 93 61 7F DC 0D 8E C6 3E A7 74 51 1B 24 B2" # 128-bit IV in hex
g_e=251 # g_e in base 10
g_c=465 # g_c in base 10
N_e=255 # N_e in base 10
N_c=1311 # N_c in base 10
x=2101864342 # x in base 10
# NOTE: Technically the program will see each input as a string. This number is so big that you should put parenthesis if you store it in a variable as a string. (You don't need the parenthsis if you copy/paste the one line command yourself to the command line)
g_y_mod_N="8995936589171851885163650660432521853327227178155593274584417851704581358902" # g^y mod N in base 10
encrypted_message_C="F2 2C 95 FC 6B 98 BE 40 AE AD 9C 07 20 3B B3 9F F8 2F 6D 2D 69 D6 5D 40 0A 75 45 80 45 F2 DE C8 6E C0 FF 33 A4 97 8A AF 4A CD 6E 50 86 AA 3E DF" # An encrypted message C in hex
plaintext_message_P="AfYw7Z6RzU9ZaGUloPhH3QpfA1AXWxnCGAXAwk3f6MoTx" # A plaintext message P as a string 

# Instead of having to copy/paste the commented command below, you can just run this script from the command line ./testYourProgram.ps1
# dotnet run "A2 2D 93 61 7F DC 0D 8E C6 3E A7 74 51 1B 24 B2" 251 465 255 1311 2101864342 8995936589171851885163650660432521853327227178155593274584417851704581358902 "F2 2C 95 FC 6B 98 BE 40 AE AD 9C 07 20 3B B3 9F F8 2F 6D 2D 69 D6 5D 40 0A 75 45 80 45 F2 DE C8 6E C0 FF 33 A4 97 8A AF 4A CD 6E 50 86 AA 3E DF" AfYw7Z6RzU9ZaGUloPhH3QpfA1AXWxnCGAXAwk3f6MoTx

dotnet run $IV $g_e $g_c $N_e $N_c $x $g_y_mod_N $encrypted_message_C $plaintext_message_P
