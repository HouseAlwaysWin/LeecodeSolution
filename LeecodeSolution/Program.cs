using System;
using SolutionLib;

namespace LeecodeSolution
{
    class Program {
        static void Main (string[] args) {
            try {
                var className = $"SolutionLib.Questions{args[0]}.Question{args[0]},SolutionLib";
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
            } catch (Exception e) {
                System.Console.WriteLine ($"Exception:{e}");
                System.Console.WriteLine ("Please,add the question number in parameter");
            }
        }

    }
}