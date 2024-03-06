Console.WriteLine("Hello, World! Mars to Earth!");


// TODO:  Take input for planet bounds

var mars = new Planet(5, 3);

// TODO: Take input for commands

var landingInstructions = "1 1 E";
var navigationInstructions = "RFRFRFRF";

var commandCentre = new CommandCentre(mars);

var endState = commandCentre.ExecuteInstructions(landingInstructions, navigationInstructions);

// TODO: output end result

