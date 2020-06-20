
/*
数值的整数次方
*/

namespace Algorithm.剑指Offer {
    public static class Power {

        static public double Perform(double _base, int exponent) {
            if (_base == 0.0 && exponent == 0) {
                return 0;
            }
            uint absExponent = (uint)(exponent < 0 ? -exponent : exponent);
            double result = UPower(_base, absExponent);
            if (exponent < 0) {
                result = 1.0 / result;
            }
            return result;
        }

        static double UPower(double _base, uint exponent) {
            if (exponent == 0) {
                return 1;
            }
            if (exponent == 1) {
                return _base;
            }
            double result = UPower(_base, exponent >> 1);
            result *= result;
            if ((exponent & 0x1) == 1) {
                result *= _base;
            }
            return result;
        }
    }
}
