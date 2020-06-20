
namespace Algorithm.剑指Offer {
    public class Print1ToMaxOfNDigital {
		
        // 方法1
        public static void Perform(int n) {
            char[] str = new char[n];
            for (int i = 0; i < str.Length; i++) {
                str[i] = '0';
            }
            while (Increase(str)) {
                Print(str);
            }
        }

        static bool Increase(char[] str) {
            int i = str.Length - 1;
            while (i >= 0) {
                int c = str[i] - '0' + 1;
                if (c > 10 || c <= 0) {
                    throw new System.Exception("无效输入");
                }
                if (c == 10) {
                    str[i] = '0';
                } else {
                    str[i] = (char)(c + '0');
                    break;
                }
                if (i == 0 && str[i] == '0') {
                    return false;
                }
                i--;
            }
            return true;
        }

        static void Print(char[] str) {
            bool shouldPrint = false;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] != '0') {
                    shouldPrint = true;
                }
                if (shouldPrint) {
                    System.Console.Write(str[i]);
                }
            }
            System.Console.WriteLine();
        }

		// 方法2，递归
        public static void Perform2(int n) {
            char[] str = new char[n];
            for (int i = 0; i < str.Length; i++) {
                str[i] = '0';
            }
            PerformRecursively(str, 0);
        }

        static void PerformRecursively(char[] str, int index) {
            if (index == str.Length) {
                Print(str);
                return;
            }
            for (int i = 0; i < 10; i++) {
                str[index] = (char)(i + '0');
                PerformRecursively(str, index + 1);
            }
        }
    }
}
