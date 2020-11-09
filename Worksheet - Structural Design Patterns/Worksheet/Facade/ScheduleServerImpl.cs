using System;

namespace Facade
{
    public class ScheduleServerImpl: IScheduleServer
    {
        public void StartBooting()
        {
            Console.WriteLine("Booting...");
        }

        public void ReadSystemConfigFile()
        {
            Console.WriteLine("Reading System Config File");
        }

        public void InitializeContext()
        {
            Console.WriteLine("Initialize Context");
        }

        public void InitializeListeners()
        {
            Console.WriteLine("Initialize Listeners");
        }

        public void CreateSystemObjects()
        {
            Console.WriteLine("Create System Objects");
        }

        public void ReleaseProcesses()
        {
            Console.WriteLine("Release Processes");
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy");
        }

        public void DestroySystemObjects()
        {
            Console.WriteLine("Destroy System Objects");
        }

        public void DestroyListeners()
        {
            Console.WriteLine("Destroy Listeners");
        }

        public void DestroyContext()
        {
            Console.WriteLine("Destroy Context");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down...");
        }
    }
}