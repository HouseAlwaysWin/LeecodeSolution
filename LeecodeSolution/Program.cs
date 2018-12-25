using System;
using System.Diagnostics;
using SolutionLib.Questions;
using SolutionLib.Tools;

namespace LeecodeSolution {
    class Program {
        static void Main (string[] args) {
            Question1 q = new Question1 ();
            WatchDog.ShowPerformance(q.TwoSum);
        }
    }
}