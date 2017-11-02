using System;

namespace PR09 {
    public class Bus {
        int _nrOfBuses, _nrOfPeople;
        
        public void FindNumbers(int people, int seats) {
            /* This is how it should be, but it doesn't work
            
            _nrOfBuses = people / seats;
            int peopleInLast = people % seats;
            
            if (peopleInLast == people) {
                _nrOfPeople = seats;
            } else {
                _nrOfBuses++;
                _nrOfPeople = peopleInLast;
            }*/
            
            if (people % seats == 0) {
                _nrOfBuses = people / seats;
                _nrOfPeople = people - seats;
                
                if (people == seats) {
                    _nrOfPeople = people;
                }
            } else {
                _nrOfBuses = people / seats + 1;
                _nrOfPeople = people % seats;
            }
        }

        public int ReturnBuses() {
            return _nrOfBuses;
        }

        public int ReturnNrOfPeople() {
            return _nrOfPeople;
        }
    }
}