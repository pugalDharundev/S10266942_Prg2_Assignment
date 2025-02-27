using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10266942_Prg2_Assignment
{
    internal class BoardingGate
    {
        private string gateName;
        public string GateName
        {
            get { return gateName; }
            set { gateName = value; }
        }

        private bool supportsCFFT;
        public bool SupportsCFFT
        {
            get { return supportsCFFT; }
            set { supportsCFFT = value; }
        }

        private bool supportsDDJB;
        public bool SupportsDDJB
        {
            get { return supportsDDJB; }
            set { supportsDDJB = value; }
        }

        private bool supportsLWTT;
        public bool SupportsLWTT
        {
            get { return supportsLWTT; }
            set { supportsLWTT = value; }
        }

        private Flight flight;
        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        public BoardingGate() { }

        public BoardingGate(string gateName, bool supportsCFFT, bool supportsDDJB, bool supportsLWTT, Flight flight)

        {

            GateName = gateName;
            SupportsCFFT = supportsCFFT;
            SupportsDDJB = supportsDDJB;
            SupportsLWTT = supportsLWTT;
            Flight = flight;
        }

        public void CalculateFees()
        {
            double fees = 0;
            if (SupportsCFFT)
            {
                fees += 50;
            }
            if (SupportsDDJB)
            {
                fees += 100;
            }
            if (SupportsLWTT)
            {
                fees += 150;
            }
            Console.WriteLine("Fees for the flight is : " + fees);
        }

        public override string ToString()
        {
            return "Gate Name : " + GateName + "\n" + "Supports CFFT : " + SupportsCFFT + "\n" + "Supports DDJB : " + SupportsDDJB + "\n" + "Supports LWTT : " + SupportsLWTT + "\n" + "Flight : " + Flight;
        }
    }
}