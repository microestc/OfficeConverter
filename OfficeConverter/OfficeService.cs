using OfficeConverter.Events;
using System.IO;

namespace OfficeConverter
{
    public class OfficeService : IOfficeService
    {
        private readonly OfficeQueue _queue;

        public OfficeService()
        {
            _queue = new OfficeQueue();
        }

        public void Convert(TaskSetup setup)
        {
            var task = new OfficeTask(setup);
            task.TaskFinishedCallback += () => TaskFinished(setup);
            task.ConvertFinishedEvent += ConvertFinished;
            task.ConvertProgressEvent += ConvertProgress;
            _queue.EnqueueTask(task);
        }

        public virtual void ConvertFinished(object sender, ConvertFinishedEventArgs args)
        {
            var setup = args.Setup;

        }

        public virtual void ConvertProgress(object sender, ConvertProgressEventArgs args)
        {
            //if (OfficeTask.ProgressCompleted(sender, args, out var setup)) { }
            //if (OfficeTask.GainedDuration(sender, args, out var setup)) { }
        }

        public virtual void TaskFinished(TaskSetup setup)
        {
            if (!string.IsNullOrWhiteSpace(setup.Source))
                File.Delete(setup.Source);
            if (setup.CompletedCallBack != null)
                setup.CompletedCallBack(setup);
        }
    }
}
