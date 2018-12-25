using System;
using System.Diagnostics;
using SolutionLib.Questions;
using SolutionLib.Tools;

namespace LeecodeSolution {
    class Program {
        static void Main (string[] args) {
            int[] nums = { 1, 2, 3, 4 };
            int target = 7;
            Question1 q1 = new Question1 ();
            WatchDog.ShowPerformance(q1.TwoSum, nums, target);
        }
    }
}