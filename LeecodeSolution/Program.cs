using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using SolutionLib.Questions;
using SolutionLib.Tools;

namespace LeecodeSolution {
    class Program {
        static void Main (string[] args) {
            var className = $"SolutionLib.Questions.Question{args[0]},SolutionLib";
            Type type = Type.GetType (className);
            if (type != null) {
                var obj = Activator.CreateInstance (type);
                if (obj != null) {
                    IQuestion q = (IQuestion) obj;
                    q.Run ();
                } else {
                    System.Console.WriteLine ("Please,add the correct question number in parameter");
                }
            } else {
                System.Console.WriteLine ("Please,add the question number in parameter");
            }
        }

    }
}