namespace HW10.Ex1 {
    public class DogFactory {
        public IDog GetDog(string criteria) {
            switch (criteria) {
                case "small":
                    return new Poodle();
                case "big":
                    return new Rottweiler();
                case "working":
                    return new SiberianHusky();
                default:
                    return null;
            }
        }
    }
}