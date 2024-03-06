# Martian Robot Console Application

## Overview
This console application simulates the movement of robots on the surface of Mars within a rectangular grid. The robots receive instructions from Earth and move accordingly, with each instruction being either to turn left, turn right, or move forward.

## Installation
To run the application, you'll need:
- .NET Core SDK installed on your machine
- A text editor or an IDE (e.g., Visual Studio Code, Visual Studio)

Clone this repository to your local machine:
```
git clone <repository-url>
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