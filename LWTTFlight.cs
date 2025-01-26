namespace S10266695_prg2_assignment
{
    internal class LWTFlight : Flight
    {
        private double requestFee;

        public double RequestFee
        {
            get { return requestFee; }
            set { requestFee = value; }
        }

        public LWTFlight(string flightNumber, string origin, string destination, DateTime expectedTime, string status, double requestFee)
            : base(flightNumber, origin, destination, expectedTime, status)
        {
            RequestFee = requestFee;
        }

        public override double CalculateFees()
        {
            return requestFee + 200.0;
        }

        public override string ToString()
        {
            return base.ToString() + $" (LWTFlight, Request Fee: {requestFee})";
        }
    }
}
