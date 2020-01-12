
namespace Algorithm.字符串排序 {
    public class LSD {
        /// <summary>
        /// 低位优先的字符串排序，适用于字符串长度相等的字符串排序
        /// </summary>
        /// <param name="a">待排序字符串数组，数组中每个字符串的长度需要相等</param>
        /// <param name="W">数组中每个字符串的长度</param>
        public static void Sort(string[] a, int W) {
            // 参考键索引计数法
            int N = a.Length;
            int R = 256;    // 扩展ASCⅡ码字符数
            string[] aux = new string[N];
            for (int d = W - 1; d >= 0; d--) {
                // 统计频率
                int[] count = new int[R + 1];
                for (int i = 0; i < N; i++) {
                    int key = a[i][d];  //将字符串转为对应的ASCⅡ码
                    count[key + 1]++;
                }
                // 将频率转换为索引
                for (int i = 1; i < count.Length; i++) {
                    count[i] = count[i - 1] + count[i];
                }
                // 数据分类
                for (int i = 0; i < N; i++) {
                    int key = a[i][d];
                    int index = count[key]++;
                    aux[index] = a[i];
                }
                // 回写
                for (int i = 0; i < N; i++) {
                    a[i] = aux[i];
                }
            }
        }
    }
}
