namespace S10266942_Prg2_Assignment

internal class NORMFlight : Flight
{
    public NORMFlight(string flightNumber, string origin, string destination, DateTime expectedTime, string status)
        : base(flightNumber, origin, destination, expectedTime, status)
    {
    }

    public override double CalculateFees()
    {
        return 100.0;
    }

    public override string ToString()
    {
        return base.ToString() + " (NORMFlight)";
    }
}
