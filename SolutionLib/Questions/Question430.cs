using System.Collections.Generic;
using SolutionLib.Questions;
using SolutionLib.Tools;

namespace SolutionLib.Questions430 {

    public class Node {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public Node () { }
        public Node (int _val, Node _prev, Node _next, Node _child) {
            val = _val;
            prev = _prev;
            next = _next;
            child = _child;
        }
    }
    public class Question430 : IQuestion {
        /*
                You are given a doubly linked list which in addition to the next and previous pointers, 
                it could have a child pointer,
                which may or may not point to a separate doubly linked list.
                These child lists may have one or more children of their own, and so on, to produce a multilevel data structure, 
                as shown in the example below.

                Flatten the list so that all the nodes appear in a single-level, doubly linked list. 
                You are given the head of the first level of the list.

        

                Example:

                Input:
                1---2---3---4---5---6--NULL
                        |
                        7---8---9---10--NULL
                            |
                            11--12--NULL

                Output:
                1-2-3-7-8-11-12-9-10-4-5-6-NULL
                 */
        public void Run () {
            Node node = new Node (1, null, null, null);
            Node refs = node;
            Node child1 = new Node (7, null, null, null);
            Node child1_refs = child1;
            Node child2 = new Node (11, null, null, null);
            Node child2_refs = child2;

            for (int i = 12; i < 13; i++) {
                Node new_node = new Node (i, child2_refs, null, null);
                child2_refs.next = new_node;
                child2_refs = child2_refs.next;
            }
            for (int i = 8; i < 11; i++) {
                Node new_node = new Node (i, child1_refs, null, null);
                if (i == 8) {
                    new_node.child = child2;
                    child2.prev = new_node;
                }
                child1_refs.next = new_node;

                child1_refs = child1_refs.next;
            }

            for (int i = 2; i < 7; i++) {
                Node new_node = new Node (i, refs, null, null);
                if (i == 3) {
                    child1.prev = new_node;
                    new_node.child = child1;
                }
                refs.next = new_node;
                refs = refs.next;
            }

            WatchDog.ShowPerformance<Node, Node> (Flatten, node);
        }

        public Node Flatten (Node head) {
            var curr = head;
            var node = head;
            Stack<Node> childs = new Stack<Node> ();
            while (curr != null) {

                if (curr.child != null) {
                    if (curr.next != null) {
                        childs.Push (curr.next);
                    } 
                    var child = curr.child;
                    child.prev = curr;
                    curr.next = child;
                    curr.child = null;
                    curr = curr.next;
                } else {
                    if (curr.next == null && childs.Count != 0) {
                        var refs = childs.Pop ();
                        refs.prev = curr;
                        curr.next = refs;
                    }
                    curr = curr.next;
                }
            }

            return head;
        }

    }
}