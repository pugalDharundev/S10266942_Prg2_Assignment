namespace S10266942_Prg2_Assignment
{
    internal class Flight
    {
        private string flightNumber;
        private string origin;
        private string destination;
        private DateTime expectedTime;
        private string status;

        public string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public DateTime ExpectedTime
        {
            get { return expectedTime; }
            set { expectedTime = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Flight(string flightNumber, string origin, string destination, DateTime expectedTime, string status)
        {

            FlightNumber = flightNumber;
            Origin = origin;
            Destination = destination;
            ExpectedTime = expectedTime;
            Status = status;
        }

        public virtual double CalculateFees()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Flight: {FlightNumber}, Origin: {Origin}, Destination: {Destination}, Expected: {ExpectedTime}, Status: {Status}";
        }
    }
}