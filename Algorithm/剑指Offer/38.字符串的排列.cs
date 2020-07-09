
namespace Algorithm.剑指Offer {
    public class Permutation {

        public static void Perform(char[] str, int start) {
            if (start == str.Length) {
                System.Console.WriteLine(str);
                return;
            }
            for (int k = start; k < str.Length; k++) {
                char temp = str[start];
                str[start] = str[k];
                str[k] = temp;

                Perform(str, start + 1);

                temp = str[start];
                str[start] = str[k];
                str[k] = temp;
            }
        }

        static void Test() {
            char[] str = "abcd".ToCharArray();
            Permutation.Perform(str, 0);
        }
    }
}
