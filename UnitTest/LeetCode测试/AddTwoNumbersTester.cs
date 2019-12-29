using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.LeetCode测试 {
    [TestClass]
    public class AddTwoNumbersTester {

        [TestMethod]
        public void TestCase1() {
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(3);
            l1.next = l2;
            l2.next = l3;

            ListNode n1 = new ListNode(5);
            ListNode n2 = new ListNode(6);
            ListNode n3 = new ListNode(4);
            n1.next = n2;
            n2.next = n3;

            ListNode r = AddTwoNumbsers.Perform(l1, n1);
            int[] result = new int[] { 7, 0, 8 };
            int i = 0;
            while (r != null && i < result.Length) {
                Assert.AreEqual(r.val, result[i]);
                r = r.next;
                i++;
            }
        }

        [TestMethod]
        public void TestCase2() {
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(5);
            l1.next = l2;
            l2.next = l3;

            ListNode n1 = new ListNode(5);
            ListNode n2 = new ListNode(6);
            ListNode n3 = new ListNode(4);
            n1.next = n2;
            n2.next = n3;

            ListNode r = AddTwoNumbsers.Perform(l1, n1);
            int[] result = new int[] { 7, 0, 0, 1 };
            int i = 0;
            while (r != null && i < result.Length) {
                Assert.AreEqual(r.val, result[i]);
                r = r.next;
                i++;
            }
        }

        [TestMethod]
        public void TestCase3() {
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(5);
            ListNode l4 = new ListNode(6);
            ListNode l5 = new ListNode(3);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;

            ListNode n1 = new ListNode(5);
            ListNode n2 = new ListNode(6);
            ListNode n3 = new ListNode(4);
            n1.next = n2;
            n2.next = n3;

            ListNode r = AddTwoNumbsers.Perform(l1, n1);
            int[] result = new int[] { 7, 0, 0, 7, 3 };
            int i = 0;
            while (r != null && i < result.Length) {
                Assert.AreEqual(r.val, result[i]);
                r = r.next;
                i++;
            }
        }

        [TestMethod]
        public void TestCase4() {
            ListNode n1 = new ListNode(5);
            ListNode n2 = new ListNode(6);
            ListNode n3 = new ListNode(4);
            n1.next = n2;
            n2.next = n3;

            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(5);
            ListNode l4 = new ListNode(6);
            ListNode l5 = new ListNode(3);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            
            ListNode r = AddTwoNumbsers.Perform(n1, l1);
            int[] result = new int[] { 7, 0, 0, 7, 3 };
            int i = 0;
            while (r != null && i < result.Length) {
                Assert.AreEqual(r.val, result[i]);
                r = r.next;
                i++;
            }
        }
    }
}
