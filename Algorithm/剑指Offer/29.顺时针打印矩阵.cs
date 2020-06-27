using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.剑指Offer {
    class PrintCircle {
        public static void Perform(int[,] arr2d) {
            printCircleCore(arr2d, 0, 0, arr2d.GetLength(0) - 1, arr2d.GetLength(1) - 1);
        }

        static void printCircleCore(int[,] arr2d, int xMin, int yMin, int xMax, int yMax) {
            while (xMin <= xMax && yMin <= yMax) {
                for (int y = yMin; y <= yMax; y++) {
                    System.Console.WriteLine(arr2d[xMin, y]);
                }
                for (int x = xMin + 1; x <= xMax; x++) {
                    System.Console.WriteLine(arr2d[x, yMax]);
                }
                for (int y = yMax - 1; y >= yMin; y--) {
                    System.Console.WriteLine(arr2d[xMax, y]);
                }
                for (int x = xMax - 1; x >= xMin + 1; x--) {
                    System.Console.WriteLine(arr2d[x, yMin]);
                }
                xMin += 1;
                yMin += 1;
                xMax -= 1;
                yMax -= 1;
            }
        }
    }
}
