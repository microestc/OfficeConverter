using System;

namespace Microestc.OfficeConverter.Events
{
    public class ConvertFinishedEventArgs : EventArgs
    {
        public TimeSpan ElapsedTime { get; set; }

        public TaskSetup Setup { get; set; }

        public ConvertFinishedEventArgs(TimeSpan elapsedTime, TaskSetup setup)
        {
            ElapsedTime = elapsedTime;
            Setup = setup;
        }
    }
}
