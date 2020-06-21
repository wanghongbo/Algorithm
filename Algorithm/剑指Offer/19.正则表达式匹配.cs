
namespace Algorithm.剑指Offer {
    public static class PatternMatch {

        public static bool Perform(string str, string pattern) {
            return Mach(str, 0, pattern, 0);
        }

        static bool Mach(string str, int i, string pattern, int j) {
            if (i == str.Length && j == pattern.Length) {
                return true;
            }
            if (i == str.Length && j != pattern.Length) {
                return false;
            }
            if (i != str.Length && j == pattern.Length) {
                return false;
            }
            if (j + 1 < pattern.Length && pattern[j + 1] == '*') {
                if (str[i] == pattern[j] || pattern[j] == '.') {
                    return Mach(str, i, pattern, j + 2) || Mach(str, i + 1, pattern, j + 2) || Mach(str, i + 1, pattern, j);
                } else {
                    return Mach(str, i, pattern, j + 2);
                }
            } else {
                if (str[i] == pattern[j] || pattern[j] == '.') {
                    return Mach(str, i + 1, pattern, j + 1);
                }
                return false;
            }
        }
    }
}
