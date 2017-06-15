using System;
using System.Diagnostics;

using TargetFramework;
using NetCore;
using NetFramework;
using NetStandard;

namespace MyApp
{
    class Program
    {
        static void Main (string[] args)
        {
            RunAppWithTargetFramework<NetFramework45>();
            RunAppWithTargetFramework<NetCore20>();
        }

        static void RunAppWithTargetFramework<T>() where T : ITargetFramework, new()
        {
            var watch = Stopwatch.StartNew();

            MyApp.Start(new T());

            watch.Stop();
            Console.WriteLine($"Executing on {typeof(T).Name}, Elapsed Time: {watch.ElapsedMilliseconds}");

        }
    }

    static class MyApp
    {
        // Could be ASPNET App or Console App
        public static void Start<T>(T targetFramework) where T : ITargetFramework
        {
            var dependency = new MyLib((ITargetFramework)targetFramework);
            var result = dependency.ComplexAwesomeCalculation();
            Console.WriteLine(result);
        }
    }
}
