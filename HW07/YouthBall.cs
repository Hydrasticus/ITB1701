using System.CodeDom;

namespace HW07 {
    public class YouthBall : NormalBall {
        
        public YouthBall(string sponsor) : base(sponsor) {
            _diameter = 0.56;
            _goalDepth = 1.4;
            _weight = 0.38;
            _codeLetters = 3;
            _codeLength = 6;
        }
    }
}