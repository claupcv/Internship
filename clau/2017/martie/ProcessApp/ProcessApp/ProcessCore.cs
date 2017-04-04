using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ProcessApp
{
    class ProcessCore
    {
        public int ID { get; private set; }

        public ProcessCore()
        {
            // Show all processes on the local computer.
            Process[] processes = Process.GetProcesses();
            // Display count.
            Console.WriteLine("Count: {0}", processes.Length);
            // Loop over processes.
            foreach (Process process in processes)
            {
                Console.WriteLine("{0} - {1} - {2}", process.Id, process.ProcessName, process.Threads);
            }
        }
    }
}
