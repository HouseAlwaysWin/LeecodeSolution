using System;
using System.Diagnostics;
using Newtonsoft.Json;
namespace SolutionLib.Tools {
    public class WatchDog {

        public static void ShowPerformance (Action method) {
            Stopwatch watch = new Stopwatch ();
            watch.Start ();
            method ();
            watch.Stop ();
            System.Console.WriteLine ($"TimeSpan elapsed time:{watch.Elapsed}");
        }

        public static void ShowPerformance<T> (Action<T> method, T t) {
            Stopwatch watch = new Stopwatch ();
            watch.Start ();
            method (t);
            watch.Stop ();
            System.Console.WriteLine ($"TimeSpan elapsed time:{watch.Elapsed}");
        }

        public static void ShowPerformance<T1, T2> (Action<T1, T2> method, T1 t1, T2 t2) {
            Stopwatch watch = new Stopwatch ();
            watch.Start ();
            method (t1, t2);
            watch.Stop ();
            System.Console.WriteLine ($"TimeSpan elapsed time:{watch.Elapsed}");
        }

        public static void ShowPerformance<T1, T2> (Func<T1, T2> method, T1 t1) {
            Stopwatch watch = new Stopwatch ();
            watch.Start ();
            var result = method (t1);
            watch.Stop ();
            string jsonResult = JsonConvert.SerializeObject (result);
            System.Console.WriteLine ($"TimeSpan elapsed time:{watch.Elapsed}");
            System.Console.WriteLine ($"Result:{jsonResult}");
        }

        public static void ShowPerformance<T1, T2, T3> (Func<T1, T2, T3> method, T1 t1, T2 t2, bool showResult = true) {
            Stopwatch watch = new Stopwatch ();
            watch.Start ();
            var result = method (t1, t2);
            watch.Stop ();
            System.Console.WriteLine ($"TimeSpan elapsed time:{watch.Elapsed}");
            if (showResult) {
                string jsonResult = JsonConvert.SerializeObject (result);
                System.Console.WriteLine ($"Result:{jsonResult}");
            }
        }

    }
}