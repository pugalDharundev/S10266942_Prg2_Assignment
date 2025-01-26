using S10266695_prg2_assignment;

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