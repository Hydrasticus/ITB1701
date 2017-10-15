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
        internal bool _isPowerOn, _isSteamOn;
        internal int _temperature, _ironingCounter = 0;
        internal const int LINEN_MIN = 200;
        private const int COTTON_MIN = 150, SILK_MIN = 120, MINIMUM_TEMP = 90;
        internal string _machineType, _program;
        internal const string OUTPUT_PROGRAM = "{0} is ironing with {1} program.";
        internal const string OUTPUT_TEMP = "{0} is ironing with {1} degrees.";
        internal Random random = new Random();

        public RegularIron() {
            _machineType = "Regular machine";
            _isPowerOn = true;
        }
        
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
                    string output;

                    if (_temperature >= MINIMUM_TEMP && _temperature < SILK_MIN) {
                        _program = "Synthetics";
                        output = string.Format(OUTPUT_PROGRAM, _machineType, _program);
                    } else if (_temperature >= SILK_MIN && _temperature < COTTON_MIN) {
                        _program = "Silk";
                        output = string.Format(OUTPUT_PROGRAM, _machineType, _program);
                    } else if (_temperature >= COTTON_MIN && _temperature < LINEN_MIN) {
                        _program = "Cotton";
                        output = string.Format(OUTPUT_PROGRAM, _machineType, _program);
                    } else {
                        output = "Invalid temperature range for ironing!";
                    }
                    
                    if (_isSteamOn) {
                        if (_temperature >= SILK_MIN) {
                            output += " Ironing with steam.";
                        } else
                            Console.WriteLine("The temperature must be at least 120 degrees to use steam!");
                    }

                    Console.WriteLine(output);

                    if (output != "Invalid temperature range for ironing!") {
                        _ironingCounter++;
                    }
                    
                    _isSteamOn = false;
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }

        public virtual void DoIroning(string program) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_ironingCounter != 3) {
                    string output;
                    
                    if (program == "Synthetics" || program == "synthetics") {
                        _temperature = random.Next(MINIMUM_TEMP, SILK_MIN);
                        output = string.Format(OUTPUT_TEMP, _machineType, _temperature);
                    } else if (program == "Silk" || program == "silk") {
                        _temperature = random.Next(SILK_MIN, COTTON_MIN);
                        output = string.Format(OUTPUT_TEMP, _machineType, _temperature);
                    } else if (program == "Cotton" || program == "cotton") {
                        _temperature = random.Next(COTTON_MIN, LINEN_MIN);
                        output = string.Format(OUTPUT_TEMP, _machineType, _temperature);
                    } else {
                        output = "Invalid program!";
                    }

                    if (_isSteamOn) {
                        if (_temperature >= SILK_MIN) {
                            output += " Ironing with steam.";
                        } else
                            Console.WriteLine("The temperature must be at least 120 degrees to use steam!");
                    }
                    
                    Console.WriteLine(output);
                    
                    if (output != "Invalid temperature range for ironing!") {
                        _ironingCounter++;
                    }
                    
                    _isSteamOn = false;
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }

        public virtual void UseSteam() {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_isSteamOn) {
                    Console.WriteLine("The steam is already on!");
                } else
                    _isSteamOn = true;
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
                Console.WriteLine("Machine turned off.");
            }
        }
    }

    public class LinenIron : RegularIron {
        private const int LINEN_MAX = 230;

        public LinenIron() {
            _machineType = "Linen machine";
            _isPowerOn = true;
        }
        
        public override void DoIroning(int temperature) {
            if (!_isPowerOn) {
                Console.WriteLine("Turn the machine on first!");
            } else {
                if (_ironingCounter != 3) {
                    _temperature = temperature;

                    if (_temperature >= LINEN_MIN && _temperature <= LINEN_MAX) {
                        _program = "Linen";
                        string output = string.Format(OUTPUT_PROGRAM, _machineType, _program)
                                        + " Ironing with steam.";
                        
                        Console.WriteLine(output);
                        
                        _ironingCounter++;
                        _isSteamOn = false;
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
                    if (program == "Linen" || program == "linen") {
                        _temperature = random.Next(LINEN_MIN, LINEN_MAX + 1);
                        string output = string.Format(OUTPUT_TEMP, _machineType, _temperature)
                                        + " Ironing with steam.";
                        
                        Console.WriteLine(output);

                        _ironingCounter++;
                        _isSteamOn = false;
                    } else
                        base.DoIroning(program);
                } else
                    Console.WriteLine("The machine has been used 3 times and needs cleaning.");
            }
        }
    }
    
    public class PremiumIron : RegularIron {
        private bool _isWaterIndicatorOn;
        private int _steamUsageCounter;

        public PremiumIron() {
            _machineType = "Premium machine";
            _isPowerOn = true;
            _isWaterIndicatorOn = false;
        }
        
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

                if (_isWaterIndicatorOn) {
                    Console.WriteLine("Warning: water supply running low! Add water soon!");
                } else if (_steamUsageCounter != 2) {
                    _steamUsageCounter++;
                } else
                    _isWaterIndicatorOn = true;
            }
        }
    }
}