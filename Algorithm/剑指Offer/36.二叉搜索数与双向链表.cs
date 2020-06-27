
namespace Algorithm.剑指Offer {
    class ConvertTwoWayLinkedList {
        public static Component Perform(Node head) {
            if (head == null) return null;
            Component n = new Component();
            Component componentLeft = Perform(head.left);
            Component componentRight = Perform(head.right);
            if (componentLeft != null) {
                n.front = componentLeft.front;
                componentLeft.end.left = head;
                head.right = componentLeft.end;
            } else {
                n.front = head;
            }
            if (componentRight != null) {
                n.end = componentRight.end;
                componentRight.front.right = head;
                head.left = componentRight.front;
            } else {
                n.end = head;
            }
            return n;
        }
    }

    class Node {
        public int value;
        public Node left;
        public Node right;

        public Node(int v) {
            this.value = v;
        }
    }

    class Component {
        public Node front;
        public Node end;
    }
}
