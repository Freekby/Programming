﻿namespace Programming
{
    public class Flight
    {
        private int flightTimeInMinutes;

        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }

        public Flight()
        {
        }

        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
        public int FlightTimeInMinutes
        {
            get { return flightTimeInMinutes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Время полета не может быть отрицательным.");
                }
                flightTimeInMinutes = value;
            }
        }
    }
}
