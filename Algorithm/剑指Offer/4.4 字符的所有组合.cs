using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.剑指Offer {
    public class CharsCombination {

        public static void Test() {
            char[] str = "abcd".ToCharArray();
            CharsCombination.Perform(str);
        }

        public static void Perform(char[] str) {
            for (int m = 1; m <= str.Length; m++) {
                Stack<char> stack = new Stack<char>();
                Combination(str, 0, m, stack);
            }
        }

        static void Combination(char[] str, int start, int m, Stack<char> stack) {
            if (m == 0) {
                PrintStack(stack);
                return;
            }
            int n = str.Length;
            if (start == str.Length) {
                return;
            }
            char first = str[start];
            stack.Push(first);
            Combination(str, start + 1, m - 1, stack);
            stack.Pop();
            Combination(str, start + 1, m, stack);
        }

        static void PrintStack(Stack<char> stack) {
            if (stack.Count > 0) {
                Stack<char> stack2 = new Stack<char>();
                while (stack.Count > 0) {
                    char c = stack.Pop();
                    stack2.Push(c);
                }
                while (stack2.Count > 0) {
                    char c = stack2.Pop();
                    System.Console.Write(c);
                    stack.Push(c);
                }
                System.Console.WriteLine();
            }
        }
    }
}
