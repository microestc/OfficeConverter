using System;

namespace Microestc.OfficeConverter.Events
{
    public class ConvertTaskFinishedEventArgs : EventArgs
    {
        public OfficeTask FinishedTask { get; set; }

        public ConvertTaskFinishedEventArgs(OfficeTask task)
        {
            FinishedTask = task;
        }
    }
}
