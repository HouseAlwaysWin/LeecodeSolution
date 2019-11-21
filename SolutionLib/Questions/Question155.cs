using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace SolutionLib.Questions155 {
    public class Question155 : IQuestion {
        /*
        Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

        push(x) -- Push element x onto stack.
        pop() -- Removes the element on top of the stack.
        top() -- Get the top element.
        getMin() -- Retrieve the minimum element in the stack.
        

        Example:

        MinStack minStack = new MinStack();
        minStack.push(-2);
        minStack.push(0);
        minStack.push(-3);
        minStack.getMin();   --> Returns -3.
        minStack.pop();
        minStack.top();      --> Returns 0.
        minStack.getMin();   --> Returns -2.
        */
        public void Run () {
            Stopwatch watch = new Stopwatch ();
            watch.Start ();
            MinStack minStack = new MinStack ();
            minStack.Push (-2);
            minStack.Push (0);
            minStack.Push (-3);
            System.Console.WriteLine (minStack.GetMin ()); //-- > Returns - 3.
            minStack.Pop ();
            System.Console.WriteLine (minStack.Top ());
            minStack.GetMin (); //-- > Returns - 2.
            watch.Stop ();
            System.Console.WriteLine ($"TimeSpan elapsed time:{watch.Elapsed}");
            watch.Reset ();
            watch.Start ();
            Stack<int> stack = new Stack<int> ();
            stack.Push (-2);
            stack.Push (0);
            stack.Push (-3);
            stack.Min ();
            stack.Pop ();
            stack.Last ();
            stack.Min ();
            watch.Stop ();
            System.Console.WriteLine ($"TimeSpan elapsed time:{watch.Elapsed}");
        }

    }
    public class MinStack {

        public class Node {
            public int val;
            public Node next;
            public Node (int val) {
                this.val = val;
            }
        }

        public Node head;
        int min;

        /** initialize your data structure here. */
        public MinStack () { }

        public void Push (int x) {
            if (head == null) {
                var node = new Node (x);
                head = node;
            } else {
                var new_node = new Node (x);
                var tmp = head;
                new_node.next = tmp;
                head = new_node;
            }
        }

        public void Pop () {
            head = head.next;
        }

        public int Top () {
            return head.val;
        }

        public int GetMin () {
            var curr = head;
            int min = curr.val;
            while (curr != null) {
                if (curr.val < min) {
                    min = curr.val;
                }
                curr = curr.next;
            }
            return min;
        }
    }
}