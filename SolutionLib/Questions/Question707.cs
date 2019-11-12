namespace SolutionLib.Questions707 {
    public class Question707 : IQuestion {
        /*
         Design your implementation of the linked list. You can choose to use the singly linked list or the doubly linked list.
         A node in a singly linked list should have two attributes: val and next.
         val is the value of the current node, and next is a pointer/reference to the next node. 
         If you want to use the doubly linked list, you will need one more attribute prev to indicate the previous node in the linked list. 
         Assume all nodes in the linked list are 0-indexed.

        Implement these functions in your linked list class:

        get(index) : Get the value of the index-th node in the linked list. If the index is invalid, return -1.
        addAtHead(val) : Add a node of value val before the first element of the linked list.
        After the insertion, the new node will be the first node of the linked list.
        addAtTail(val) : Append a node of value val to the last element of the linked list.
        addAtIndex(index, val) : Add a node of value val before the index-th node in the linked list. 
        If index equals to the length of linked list, the node will be appended to the end of linked list. 
        If index is greater than the length, the node will not be inserted.
        deleteAtIndex(index) : Delete the index-th node in the linked list, if the index is valid.
        

        Example:

        Input: 
        ["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
        [[],[1],[3],[1,2],[1],[1],[1]]
        Output:  
        [null,null,null,null,2,null,3]

        Explanation:
        MyLinkedList linkedList = new MyLinkedList(); // Initialize empty LinkedList
        linkedList.addAtHead(1);
        linkedList.addAtTail(3);
        linkedList.addAtIndex(1, 2);  // linked list becomes 1->2->3
        linkedList.get(1);            // returns 2
        linkedList.deleteAtIndex(1);  // now the linked list is 1->3
        linkedList.get(1);            // returns 3
        

        Constraints:

        0 <= index,val <= 1000
        Please do not use the built-in LinkedList library.
        At most 2000 calls will be made to get, addAtHead, addAtTail,  addAtIndex and deleteAtIndex.

         */
        public void Run () {
            MyLinkedList l = new MyLinkedList ();
            l.AddAtHead (4);
            l.AddAtHead (3);
            l.AddAtHead (2);
            l.AddAtHead (1);
            l.AddAtTail (0);
            l.AddAtIndex (2, 15);
            System.Console.WriteLine (l.Get (2));
            
        }

    }

    public class MyLinkedList {
        public class Node {
            public int val;
            public Node next;
            public Node (int val) {
                this.val = val;
            }
        }

        public Node next;
        private Node tail;

        private int length;

        /** Initialize your data structure here. */
        public MyLinkedList () {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get (int index) {
            if (index < 0 || index >= length) return -1;
            var refs = this.next;
            var count = 0;
            while (index != count) {
                refs = refs.next;
                count++;
            }
            return refs.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead (int val) {
            var node = new Node (val);
            node.next = next;
            next = node;
            if (tail == null)
                tail = node;
            length++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail (int val) {
            var node = new Node (val);
            if (tail == null) {
                next = node;
                tail = node;
            } else {
                tail.next = node;
                tail = node;
            }
            length++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex (int index, int val) {
            if (index == 0) {
                AddAtHead (val);
            } else if (length == index) {
                AddAtTail (val);
            } else {
                int count = 0;
                var prev = this.next;
                while (count != index - 1) {
                    prev = prev.next;
                    count++;
                }
                Node node = new Node (val);
                var tmp = prev.next;
                prev.next = node;
                node.next = tmp;
                length++;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex (int index) {
            if (index < 0 || index >= length) return;
            else if (index == 0) {
                this.next = this.next.next;
                if (next == null) {
                    this.tail = null;
                }
                length--;
            } else {
                var prev = this.next;
                int count = 0;
                while (count != index - 1) {
                    prev = prev.next;
                    count++;
                }
                if (prev.next == tail) {
                    tail = prev;
                }
                prev.next = prev.next.next;
                length--;
            }
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}