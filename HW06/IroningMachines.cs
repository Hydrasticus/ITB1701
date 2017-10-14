using System;

namespace HW06 {
    // TODO: test classes and methods
    
    interface IIroningMachines {
        void Descale();
        void DoIroning(int temperature);
        void DoIroning(string program);
        void UseSteam();
        void TurnOn();
        void TurnOff();
    }
    
    public class RegularIron : IIroningMachines {
        internal bool _isPowerOn = true;
        internal const int COTTON_MAX = 199, SILK_MAX = 149, SYNTHETICS_MAX = 119, MINIMUM_TEMP = 90;
        internal int _temperature, _ironingCounter = 0, _steamSwitch = 0;
        internal const string OUTPUT_PROGRAM = "{0} is ironing with {1} program.";
        internal const string OUTPUT_TEMP = "{0} is ironing with {1} degrees.";
        private const string MACHINE_TYPE = "Regular machine";
        internal string _program;
        internal Random _random = new Random();

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
                if (_ironingCounter != 3) {
                    _temperature = temperature;
                    string output = string.Format(OUTPUT_PROGRAM, MACHINE_TYPE, _program);

                    if (_steamSwitch == 1) {
                        output += " Ironing with steam.";
                    }

                    if (_temperature >= MINIMUM_TEMP && _temperature <= SYNTHETICS_MAX) {
                        _program = "Synthetics";
                        Console.WriteLine(output);
                    } else if (_temperature > SYNTHETICS_MAX && _temperature <= SILK_MAX) {
                        _program = "Silk";
                        Console.WriteLine(output);
                    } else if (_temperature > SILK_MAX && _temperature <= COTTON_MAX) {
                        _program = "Cotton";
                        Console.WriteLine(output);
                    } else {
                        Console.WriteLine("Invalid temperature range for ironing!");
                    }
                    
                    _ironingCounter++;
                    _steamSwitch = 0;
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }

        public virtual void DoIroning(string program) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_ironingCounter != 3) {
                    string output = string.Format(OUTPUT_TEMP, MACHINE_TYPE, _temperature);

                    if (_steamSwitch == 1) {
                        output += " Ironing with steam.";
                    }

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
                    
                    _ironingCounter++;
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
                } else
                    _steamSwitch = 1;
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

    public class LinenIron : RegularIron {
        private const int LINEN_MAX = 230;
        private const string MACHINE_TYPE = "Linen machine";
        
        public override void DoIroning(int temperature) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_ironingCounter != 3) {
                    _temperature = temperature;
                    string output = string.Format(OUTPUT_PROGRAM, MACHINE_TYPE, _program);

                    if (_steamSwitch == 1) {
                        output += " Ironing with steam.";
                    }

                    if (_temperature > SILK_MAX && _temperature <= LINEN_MAX) {
                        _program = "Linen";
                        Console.WriteLine(output);
                        _ironingCounter++;
                        _steamSwitch = 0;
                    } else
                        base.DoIroning(temperature);
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }

        public override void DoIroning(string program) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_ironingCounter != 3) {
                    string output = string.Format(OUTPUT_TEMP, MACHINE_TYPE, _temperature);

                    if (_steamSwitch == 1) {
                        output += " Ironing with steam.";
                    }

                    if (program == "Linen" || program == "linen") {
                        _temperature = _random.Next(COTTON_MAX + 1, LINEN_MAX + 1);
                        UseSteam();
                        Console.WriteLine(output);
                        _ironingCounter++;
                        _steamSwitch = 0;
                    } else
                        base.DoIroning(program);
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }
    }
    
    public class PremiumIron : RegularIron {
        private int _waterIndicator;
        private int _steamCounter;
        private const string MACHINE_TYPE = "Premium machine";
        
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

        public override void DoIroning(string program) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_ironingCounter != 3) {
                    base.DoIroning(program);
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
                } else
                    _waterIndicator = 1;
            }
        }
    }
}