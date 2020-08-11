
namespace Algorithm.剑指Offer {
    public class FindNumsAppearOnce {

        void Test() {
            int[] arr = { 2, 1, 3, 2, 3, 4 };
            Perform(arr); // 结果：1，4
        }

        public static void Perform(int[] arr) {
            int x = 0;
            for (int i = 0; i < arr.Length; i++) {
                x = x ^ arr[i];
            }
            int n = 0x0001;
            while ((x & 0x0001) != 1) {
                x = x >> 1;
                n = n << 1;
            }
            int a = 0, b = 0;
            for (int i = 0; i < arr.Length; i++) {
                if ((arr[i] & n) == n) {
                    a = a ^ arr[i];
                } else {
                    b = b ^ arr[i];
                }
            }
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
    }
}
