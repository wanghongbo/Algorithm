
/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
*/

namespace Algorithm {
    public class AddTwoNumbsers {
        public static ListNode Perform(ListNode l1, ListNode l2) {
            ListNode head = l1, pre = l1;
            int carry = 0;  // 进位
            int val;
            while (l1 != null || l2 != null) {
                val = 0;
                if (l1 != null) {
                    val += l1.val;
                }
                if (l2 != null) {
                    val += l2.val;
                }
                val += carry;
                carry = val > 9 ? 1 : 0;    // 除法运算效率低，改用三元运算符
                if (l1 == null) {
                    pre.next = l2;
                    l1 = l2;
                    l2 = null;  // 将l2断开
                }
                l1.val = val % 10;

                pre = l1;
                if (l1 != null) {
                    l1 = l1.next;
                }
                if (l2 != null) {
                    l2 = l2.next;
                }
            }
            if (carry == 1) {
                ListNode n = new ListNode(1);
                pre.next = n;
            }

            return head;
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode(int x) {
            val = x;
        }
    }
}
