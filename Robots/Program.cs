using Robots;
using System.Xml;

Console.WriteLine("Hello, World! Mars to Earth!");

Console.WriteLine("Please specify the bounds of the Great Martian Plane");
int[]? bounds = null;
while(bounds is null)
{
    //TODO: make more robust to input errors
    var boundsInput = Console.ReadLine();
    // N.B. string.Split(null) separates by whitespace 
    bounds = boundsInput?.Split(null)?.Select(int.Parse).ToArray();
}

var mars = new Planet(bounds[0], bounds[1]);

var commandCentre = new CommandCentre(mars);

while (true)
{
    Console.WriteLine("Please specify the landing location and navigation instructions on separate lines");
    var landingInstructions = Console.ReadLine();
    var navigationInstructions = Console.ReadLine();

    if(landingInstructions is not null && navigationInstructions is not null)
    {
        if (landingInstructions.Length >= 100 || navigationInstructions.Length >= 100)
        {
            Console.WriteLine("All instruction strings must be less than 100 characters in length.");
        }
        else
        {
            var endState = commandCentre.ExecuteInstructions(landingInstructions, navigationInstructions);
            Console.WriteLine(endState);
        }
    }
}

