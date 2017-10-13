using System;

namespace HW06 {
    interface IIroningMachines {
        void Descale();
        void DoIroning(int temperature);
        void DoIroning(string program);
        void UseSteam();
        void TurnOn();
        void TurnOff();
    }
    
    public class RegularIron : IIroningMachines {
        internal bool _isPowerOn;
        internal const int COTTON_MAX = 199;
        internal const int SILK_MAX = 149;
        internal const int SYNTHETICS_MAX = 119;
        internal const int MINIMUM_TEMP = 90;
        internal int _ironingCounter = 0, _temperature, _steamSwitch = 0;
        internal string _machineType = "Regular machine";
        internal Random _random = new Random();
        internal string _output = "{0} is ironing with {1} degrees";

        public void Descale() {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                _ironingCounter = 0;
                Console.WriteLine("Machine is clean.");
            }
        }

        public virtual void DoIroning(int temperature) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                _temperature = temperature;
                if (_ironingCounter != 3) {
                    if (_temperature >= MINIMUM_TEMP && _temperature <= SYNTHETICS_MAX) {
                        Console.WriteLine(_machineType + " is ironing with Synthetics program.");
                    } else if (_temperature > SYNTHETICS_MAX && _temperature <= SILK_MAX) {
                        Console.WriteLine(_machineType + " is ironing with Silk program.");
                    } else if (_temperature > SILK_MAX && _temperature <= COTTON_MAX) {
                        Console.WriteLine(_machineType + " is ironing with Cotton program.");
                    } else
                        Console.WriteLine("Invalid temperature range for ironing!");
                    _ironingCounter++;
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }

        public virtual void DoIroning(string program) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                string output = string.Format(_output, _machineType, _temperature);

                if (_ironingCounter != 3) {
                    if (program == "Synthetics" || program == "synthetics") {
                        _temperature = _random.Next(MINIMUM_TEMP, SYNTHETICS_MAX + 1);
                        Console.WriteLine(output);
                    } else if (program == "Silk" || program == "silk") {
                        _temperature = _random.Next(SYNTHETICS_MAX + 1, SILK_MAX + 1);
                        Console.WriteLine(output);
                    } else if (program == "Cotton" || program == "cotton") {
                        _temperature = _random.Next(SILK_MAX + 1, COTTON_MAX + 1);
                        Console.WriteLine(output);
                    } else {
                        Console.WriteLine("Invalid program!");
                    }
                    _steamSwitch = 0;
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }

        public virtual void UseSteam() {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_steamSwitch == 1) {
                    Console.WriteLine("The steam is already on!");
                } else if (_temperature <= SYNTHETICS_MAX) {
                    Console.WriteLine("The temperature must be at least 120 degrees to use steam!");
                } else {
                    Console.WriteLine("Ironing with steam.");
                    _steamSwitch = 1;
                }
            }
        }

        public void TurnOn() {
            if (_isPowerOn) {
                Console.WriteLine("Machine is already turned on!");
            } else {
                _isPowerOn = true;
                Console.WriteLine("Machine turned on.");
            }
        }

        public void TurnOff() {
            if (!_isPowerOn) {
                Console.WriteLine("Machine is already turned off!");
            } else {
                _isPowerOn = false;
                Console.WriteLine("Machine turned off!");
            }
        }
    }

    public class PremiumIron : RegularIron {
        private int _waterIndicator;
        private int _steamCounter;
        
        public override void DoIroning(int temperature) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_ironingCounter != 3) {
                    base.DoIroning(temperature);
                } else
                    Descale();
            }
        }
        
        public override void UseSteam() {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                base.UseSteam();

                if (_waterIndicator == 1) {
                    Console.WriteLine("Add more water to use steam!");
                } else if (_steamCounter != 2) {
                    _steamCounter++;
                } else {
                    _waterIndicator = 1;
                }
            }
        }
    }
    
    public class LinenIron : RegularIron {
        private const int LINEN_MAX = 230;
        
        public override void DoIroning(int temperature) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                _temperature = temperature;
                _machineType = "Linen machine";

                if (_ironingCounter != 3) {
                    if (_temperature > SILK_MAX && _temperature <= LINEN_MAX) {
                        Console.WriteLine(_machineType + " is ironing with Linen program.");
                    } else
                        base.DoIroning(temperature);
                }
            }
        }

        public override void DoIroning(string program) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                string output = string.Format(_output, _machineType, _temperature);

                if (program == "Linen") {
                    _temperature = _random.Next(COTTON_MAX + 1, LINEN_MAX + 1);
                    UseSteam();
                    Console.WriteLine(output);
                }

                base.DoIroning(program);
            }
        }
    }
}