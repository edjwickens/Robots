# Martian Robot Console Application

## Overview
This console application simulates the movement of robots on the surface of Mars within a rectangular grid. The robots receive instructions from Earth and move accordingly, with each instruction being either to turn left, turn right, or move forward.

## Installation
To run the application, you'll need:
- .NET Core SDK installed on your machine
- A text editor or an IDE (e.g., Visual Studio Code, Visual Studio)

Clone this repository to your local machine:
```
git clone https://github.com/edjwickens/Robots.git
```

## Usage
1. Open a terminal or command prompt.
2. Navigate to the directory containing the application.
3. Build the application:
   ```
   dotnet build
   ```
4. Run the application:
   ```
   dotnet run
   ```
5. Follow the on-screen instructions to input the upper-right coordinates of the rectangular world and the robot positions with their instructions.

## Input Format
- The first line of input should contain the upper-right coordinates of the rectangular world.
- The subsequent lines should contain robot positions and instructions in pairs.
- Each robot position consists of two integers specifying the initial coordinates and an orientation (N, S, E, W), separated by whitespace.
- Robot instructions are strings consisting of the letters "L", "R", and "F" (left turn, right turn, and move forward), respectively.
- Each robot's instructions are processed sequentially.

## Output Format
- For each robot, the output indicates the final grid position and orientation.
- If a robot falls off the edge of the grid, the word "LOST" is printed after the position and orientation.

## Additional Notes
- The application supports future expansion for additional command types.
- The grid is bounded, and a robot falling off an edge is considered lost forever, leaving a "scent" that prevents future robots from falling off at the same grid point.

## Constraints
- Maximum coordinate value: 50
- Maximum length of instruction strings: 100 characters

## Example
Input:
```
5 3
1 1 E
RFRFRFRF
3 2 N
FRRFLLFFRRFLL
0 3 W
LLFFFLFLFL
```

Output:
```
1 1 E
3 3 N LOST
2 3 S
```

## Tests
The solution includes an XUnit test project with integration tests spanning the input to the output of the robot navigation. 
The main scenarios are covered, but more fine-grained unit tests for edge cases would be a good idea, time allowing. 

## Potential future improvements
The logic for taking the boundary size could be extracted and unit tested.
The logic for parsing and serializing the instructions and output could be extraced to enable alternative implementations, for example if the instruction protocol were changed.
Validation of user input could be improved.
Depending on future requirements, the Planet entity representing Mars could be added to a DI container as a singleton.
A backwards command could be implemented in future, or a command to move multiple grid squares, so a Move() function on the Robot class could take positive or negative integers.