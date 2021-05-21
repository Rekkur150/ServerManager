using System;
using System.Diagnostics;
using System.IO;

namespace ServerManager
{
    class ApplicationManager
    {
        private string Directory = null;
        private Process process;
        private StreamWriter input;
        private TextWriter output;

        public ApplicationManager(string applicationDirectory)
        {
            Directory = applicationDirectory;
        }

        public void Open(string ExecutablePath, string arguments = null)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(ExecutablePath);
            startInfo.Arguments = arguments;
            startInfo.WorkingDirectory = Directory;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardInput = true;

            process = Process.Start(startInfo);
            input = process.StandardInput;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (output == null)
                    return;

                if (!String.IsNullOrEmpty(e.Data))
                {
                    Console.WriteLine(e.Data);
                }
            });

            process.BeginOutputReadLine();
        }

        public void Stop()
        {
            process.Kill();
        }

        public void Run(string command)
        {
            input.WriteLine(command);
        }

        public void Output(TextWriter outputStreamWriter)
        {
            output = outputStreamWriter;
        }
    }
}
