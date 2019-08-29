using System;

namespace OfficeConverter.Events
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
