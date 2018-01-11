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
            public NegativeOrZeroException(int actual) {
                Console.WriteLine("ERROR: The number or seats is too low (must be above 0). You entered '{0}'", actual);
            }

            public NegativeOrZeroException(string currency, double actual) {
                Console.WriteLine("ERROR: The price is too low (must be above 0 {0}). You entered '{1}'",
                    currency, actual);
            }
        }
    }
}