using System;

namespace Facade
{
    public class ScheduleServerFacade
    {
        protected IScheduleServer _scheduleServer;
        
        public ScheduleServerFacade(IScheduleServer scheduleServer)
        {
            this._scheduleServer = scheduleServer;
        }

        public void StartServer()
        {
            this._scheduleServer.StartBooting();
            this._scheduleServer.ReadSystemConfigFile();
            this._scheduleServer.InitializeContext();
            this._scheduleServer.InitializeListeners();
            this._scheduleServer.CreateSystemObjects();
        }

        public void StopServer()
        {
            _scheduleServer.ReleaseProcesses();
            _scheduleServer.Destroy();
            _scheduleServer.DestroySystemObjects();
            _scheduleServer.DestroyListeners();
            _scheduleServer.DestroyContext();
            _scheduleServer.Shutdown();
        }
    }
}