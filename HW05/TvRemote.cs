using System;

namespace HW05 {
    public class TvRemote {
        // TODO: everything with channels!
        
        private int _volume = 0;
        private int _status = 0;

        public void TurnOnSystem() {
            _status = 1;
            Console.WriteLine("Turned the system on.");
        }

        public void TurnOffSystem() {
            _status = 0;
            Console.WriteLine("Turned the system off.");
        }

        public void IncreaseVolume() {
            if (_status == 0) {
                Console.WriteLine("Turn the TV on first!");
            } else {
                if (_volume >= 15) {
                    Console.WriteLine("Maximum volume reached already!");
                } else {
                    Console.WriteLine("Changed volume from {0} to {1}.", _volume, _volume + 3);
                    _volume += 3;
                }
            }
        }

        public void DecreaseVolume() {
            if (_status == 0) {
                Console.WriteLine("Turn the TV on first!");
            } else {
                if (_volume <= 0) {
                    Console.WriteLine("Minimum volume reached already!");
                } else {
                    Console.WriteLine("Changed volume from {0} to {1}.", _volume, _volume - 3);
                    _volume -= 3;
                }
            }
        }
    }
}