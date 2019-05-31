using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentProcess = Process.GetCurrentProcess();
            Console.WriteLine($"{currentProcess.Id}, {currentProcess.StartTime}, {currentProcess.ProcessName}");

            var chromeProcesses = Process.GetProcessesByName("chrome");
            foreach(var process in chromeProcesses)
            {
                process.Kill();
            }
        }
    }
}
