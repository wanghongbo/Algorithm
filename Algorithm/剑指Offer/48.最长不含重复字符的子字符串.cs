using System.Collections.Generic;

namespace Algorithm.剑指Offer {
    public class LongestSubStringWithoutDuplication {

        static void Test() {
            string str = "arabcacfrx";
            int count = Perform(str);
        }

        public static int Perform(string str) {
            int curLength = 0;
            int maxLength = 0;
            Dictionary<char, int> positions = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++) {
                char c = str[i];
                if (!positions.ContainsKey(str[i]) || i - positions[str[i]] > curLength) {
                    curLength += 1;
                } else {
                    curLength = i - positions[str[i]];
                }
                positions[str[i]] = i;
                if (curLength > maxLength) {
                    maxLength = curLength;
                }
            }

            return maxLength;
        }
    }
}
