using Practice_Assg;

// Dictionaries to store Airline and Boarding Gate objects
Dictionary<string, Airline> airlineDictionary = new Dictionary<string, Airline>();
Dictionary<string, BoardingGate> boardingGateDictionary = new Dictionary<string, BoardingGate>();

// Load airlines from airlines.csv
string airlinesFilePath = "airlines.csv";
if (File.Exists(airlinesFilePath))
{
    string[] airlineLines = File.ReadAllLines(airlinesFilePath);

    // Skip header and process each line
    for (int i = 1; i < airlineLines.Length; i++)
    {
        string line = airlineLines[i];
        string[] data = line.Split(',');

        if (data.Length >= 2)
        {
            string name = data[0].Trim();
            string code = data[1].Trim();

            // Create an Airline object and add it to the dictionary
            Airline airline = new Airline(name, code, new Dictionary<string, Flight>());
            airlineDictionary[code] = airline;
        }
        else
        {
            Console.WriteLine($"Invalid line format in airlines.csv: {line}");
        }
    }
    Console.WriteLine("Airlines loaded successfully.");
}
else
{
    Console.WriteLine($"File not found: {airlinesFilePath}");
}

// Load boarding gates from boardinggates.csv
string boardingGatesFilePath = "boardinggates.csv";
if (File.Exists(boardingGatesFilePath))
{
    string[] boardingGateLines = File.ReadAllLines(boardingGatesFilePath);

    // Skip header and process each line
    for (int i = 1; i < boardingGateLines.Length; i++)
    {
        string line = boardingGateLines[i];
        string[] data = line.Split(',');

        if (data.Length >= 4)
        {
            string gateName = data[0].Trim();

            // Parse boolean values
            if (!bool.TryParse(data[1].Trim(), out bool supportsDDJB) ||
                !bool.TryParse(data[2].Trim(), out bool supportsCFFT) ||
                !bool.TryParse(data[3].Trim(), out bool supportsLWTT))
            {
                Console.WriteLine($"Invalid boolean values in boardinggates.csv line: {line}");
                continue;
            }

            // Create a BoardingGate object and add it to the dictionary
            BoardingGate boardingGate = new BoardingGate(gateName, supportsCFFT, supportsDDJB, supportsLWTT, null);
            boardingGateDictionary[gateName] = boardingGate;
        }
        else
        {
            Console.WriteLine($"Invalid line format in boardinggates.csv: {line}");
        }
    }
    Console.WriteLine("Boarding gates loaded successfully.");
}
else
{
    Console.WriteLine($"File not found: {boardingGatesFilePath}");
}

// Output the loaded data
Console.WriteLine("\nLoaded Airlines:");
foreach (var airline in airlineDictionary.Values)
{
    Console.WriteLine(airline);
}

Console.WriteLine("\nLoaded Boarding Gates:");
foreach (var boardingGate in boardingGateDictionary.Values)
{
    Console.WriteLine(boardingGate);
}





