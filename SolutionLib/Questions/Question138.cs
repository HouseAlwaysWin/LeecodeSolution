using System;
using SolutionLib.Questions;
using SolutionLib.Tools;

namespace SolutionLib.Questions138 {

    public class Node {
        public int val;
        public Node next;
        public Node random;

        public Node () { }
        public Node (int _val, Node _next, Node _random) {
            val = _val;
            next = _next;
            random = _random;
        }
    }
    public class Question138 : IQuestion {
        /*
                A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.

                Return a deep copy of the list.

        

                Example 1:



                Input:
                {"$id":"1","next":{"$id":"2","next":null,"random":{"$ref":"2"},"val":2},"random":{"$ref":"2"},"val":1}

                Explanation:
                Node 1's value is 1, both of its next and random pointer points to Node 2.
                Node 2's value is 2, its next pointer points to null and its random pointer points to itself.
                 */

        public void Run () {

            Node node2 = new Node () {
                next = null,
                val = 2,
            };
            node2.random = node2;

            Node node1 = new Node () {
                val = 1,
                next = node2,
                random = node2
            };

            WatchDog.ShowPerformance (CopyRandomList, node1);
        }

        public Node CopyRandomList (Node head) {
            return null;
        }
    }
}