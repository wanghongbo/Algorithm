
/*
在微软产品Excel中，用A表示第1列，B表示第2列......Z表示第26列，AA表示第27列，AB表示第28列......以此类推。请写出一个函数，输入用字母表示的列号编码，输出它是第几列。
*/

namespace Algorithm.剑指Offer {
    public class Hex26 {

        // 从后往前
        static int Perform1(string str) {
            int sum = 0;
            int carry = 1;
            for (int i = str.Length - 1; i >= 0; i--) {
                char c = str[i];
                sum += (c - 'A' + 1) * carry;
                carry *= 26;
            }
            return sum;
        }

        // 从前往后
        static int Perform2(string str) {
            int sum = 0;
            for (int i = 0; i < str.Length; i++) {
                sum = sum * 26 + str[i] - 'A' + 1;
            }
            return sum;
        }
    }
}
