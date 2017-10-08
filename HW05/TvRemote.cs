using System;

namespace HW05 {
    public class TvRemote {
        private int _status = 0;
        private int _volume = 0;
        private int _channel = 0;

        public void PowerButton() {
            switch (_status) {
                    case 0:
                        _status = 1;
                        Console.WriteLine("Turned the TV on.");
                        break;
                    case 1:
                        _status = 0;
                        Console.WriteLine("Turned the TV off.");
                        break;
            }
        }
        
        public void IncreaseVolume() {
            if (_status == 0) {
                Console.WriteLine("Turn the TV on first!");
            } else {
                if (_volume == 15) {
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
                if (_volume == 0) {
                    Console.WriteLine("Minimum volume reached already!");
                } else {
                    Console.WriteLine("Changed volume from {0} to {1}.", _volume, _volume - 3);
                    _volume -= 3;
                }
            }
        }

        public void NextChannel() {
            if (_status == 0) {
                Console.WriteLine("Turn the TV on first!");
            } else {
                if (_channel == 100) {
                    Console.WriteLine("You are on the last channel already!");
                } else {
                    Console.WriteLine("Changed channel from {0} to {1}.", _channel, _channel + 1);
                    _channel++;
                }
            }
        }

        public void PreviousChannel() {
            if (_status == 0) {
                Console.WriteLine("Turn the TV on first!");
            } else {
                if (_channel == 0) {
                    Console.WriteLine("You are on the first channel already!");
                } else {
                    Console.WriteLine("Changed channel from {0} to {1}.", _channel, _channel - 1);
                    _channel--;
                }
            }
        }

        public void ChangeChannel(int channel) {
            if (_status == 0) {
                Console.WriteLine("Turn the TV on first!");
            } else {
                if (channel < 0 || channel > 100) {
                    Console.WriteLine("A channel with number {0} does not exist! Choose one from between 0-100.",
                        channel);
                } else {
                    Console.WriteLine("Changed to channel {0}.", channel);
                    _channel = channel;
                }
            }
        }
    }
}