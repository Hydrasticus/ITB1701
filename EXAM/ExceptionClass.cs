using System;

namespace EXAM {
    internal class ExceptionClass {
        internal class InvalidFlightCodeException : Exception {
            public InvalidFlightCodeException(string error) {
                Console.WriteLine("ERROR: Invalid flight code.\n'{0}'", error);
            }
        }
        
        internal class NoTicketsSoldException : Exception {
            public NoTicketsSoldException() {
                Console.WriteLine("ERROR: No tickets sold.");
            }
        }

        internal class NegativeOrZeroException : Exception {
            public NegativeOrZeroException(int input) {
                Console.WriteLine("ERROR: The number or seats is too low (must be above 0). You entered '{0}'", input);
            }

            public NegativeOrZeroException(string currency, double input) {
                Console.WriteLine("ERROR: The price is too low (must be above 0 {0}). You entered '{1}'",
                    currency, input);
            }
        }

        internal class BuyingTimeInFutureException : Exception {
            public BuyingTimeInFutureException() {
                Console.WriteLine("ERROR: Cannot buy a ticket after the flight date.");
            }
        }

        internal class BusinessClassNotAvailableException : Exception {
            public BusinessClassNotAvailableException() {
                Console.WriteLine("ERROR: Business class not available for this flight.");
            }
        }
    }
}