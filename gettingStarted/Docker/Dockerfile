# This docker image matches what the autograder will use to grade each project
# bionic is Ubuntu 18.04 and this has .NET Core 3.1 SDK (Software Development Kit)
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic

# For some reason still needs to updates
RUN apt-get update
RUN apt-get update
RUN apt-get install zip -y

# set up build enviroment to match the autograders build enviroment
WORKDIR /home/dockerTestingFolder
RUN dotnet new console --output P2
WORKDIR /home/dockerTestingFolder/P2

# We just want to copy our program's code
COPY ./P2/Program.cs .

# Use this to automatically run the code (here "C8" is the commandline input string you are feeding into your program)
CMD dotnet run "C8"


####### These steps can be used if you want to mimic what the autograder will do
####### make autograder folder
# WORKDIR /home/autograder
# COPY ./P2.zip .
####### autograder will unzip what you submitted
# RUN unzip P2.zip
####### autograder will change directory (cd) to the name of the project
# WORKDIR /home/autograder/P2
####### autograder will then run you code with some input (examples are given in the project instructions)
# RUN dotnet run "C8"
