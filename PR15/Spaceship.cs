using System;

namespace PR15 {
    public class Spaceship {
        private string _name;
        private int _index, distance;

        public Spaceship(string name, bool advanced) {
            Name = name;
            distance = advanced ? 2 : 1;
            _index = 2;
            
            Travel(_index);
        }

        public string Name {
            get => _name;
            set => _name = value;
        }

        public void Travel(int index) {
            index = Math.Abs(index);
            Planet initial = Program.solarSystem.planets[_index];

            try {
                Planet destination = Program.solarSystem.planets[index];

                if (destination != null) {
                    if (Math.Abs(_index - index) > distance) {
                        Console.WriteLine("{0}: The ship's warp drive cannot handle such a distance! " +
                                          "Try some planet that is nearer.", Name);
                    } else if (destination.spaceships.Count >= destination.ShipPlatforms) {
                        Console.WriteLine("{0}: Cannot travel to that planet at the moment, no free landing platforms.",
                            Name);
                    } else {
                        initial.spaceships.Remove(this);
                        destination.spaceships.Add(this);
                    
                        Console.WriteLine("Successfully relocated {0} to {1}.", Name, destination.Name);
                        _index = index;
                    }   
                }
            } catch (IndexOutOfRangeException) {
                Console.WriteLine("There is not a planet with index {0}.", index);
            }
        }
    }
}