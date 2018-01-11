using System;

namespace EXAM {
    internal class ExceptionClass {
        internal class InvalidFlightCodeException : Exception {
            public InvalidFlightCodeException(string error) {
                Console.WriteLine("ERROR: Invalid flight code. '{0}'", error);
            }
        }
        
        internal class NoTicketsSoldException : Exception {
            public NoTicketsSoldException() {
                Console.WriteLine("ERROR: No tickets sold.");
            }
        }

        //TODO: simplify exceptions
        internal class NegativeOrZeroPriceException : Exception {
            public NegativeOrZeroPriceException() {
                Console.WriteLine("ERROR: The price is too low (must be above 0 EUR).");
            }
        }

        internal class NegativeOrZeroNrOfSeatsException : Exception {
            public NegativeOrZeroNrOfSeatsException() {
                Console.WriteLine("ERROR: The nr of seats is too low (must be above 0).");
            }
        }
    }
}