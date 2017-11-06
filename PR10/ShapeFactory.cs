namespace PR10 {
    public class ShapeFactory {
        public IShape GetShape(int numberOfCorners) {
            if (numberOfCorners == 3) {
                return new Triangle();
            } else if (numberOfCorners == 4) {
                return new Square();
            } else if (numberOfCorners == 0) {
                return new Circle();
            } else {
                return null;
            }
        }
    }
}