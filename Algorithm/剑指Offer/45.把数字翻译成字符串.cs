
namespace Algorithm.剑指Offer {
    public class GetTranslationCount {

        void Test() {
            int num = 262;
            int count = Perform(num);
        }

        public static int Perform(int num) {
            string str = num.ToString();
            int[] aux = new int[str.Length + 1];
            for (int i = str.Length; i >= 0; i--) {
                if (i == str.Length || i == str.Length - 1) {
                    aux[i] = 1;
                } else {
                    aux[i] = aux[i + 1] + aux[i + 2] * Check(str, i, i + 1);
                }
            }
            return aux[0];
        }

        static int Check(string str, int i, int j) {
            int x = str[i] - '0';
            int y = str[j] - '0';
            int xy = x * 10 + y;
            return xy > 25 ? 0 : 1;
        }
    }
}
