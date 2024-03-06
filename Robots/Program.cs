using Robots;

Console.WriteLine("Hello, World! Mars to Earth!");

Console.WriteLine("Please specify the bounds of the Great Martian Plane");
int[]? bounds = null;
while(bounds is null)
{
    //TODO: make more robust to input errors
    var boundsInput = Console.ReadLine();
    bounds = boundsInput?.Split(null)?.Select(int.Parse).ToArray();
}

var mars = new Planet(bounds[0], bounds[1]);

var commandCentre = new CommandCentre(mars);
while (true)
{
    //TODO: make more robust to input errors
    Console.WriteLine("Please specify the landing location and navigation instructions on separate lines");
    var landingInstructions = Console.ReadLine();
    var navigationInstructions = Console.ReadLine();

    var endState = commandCentre.ExecuteInstructions(landingInstructions, navigationInstructions);

    Console.WriteLine(endState);
}

