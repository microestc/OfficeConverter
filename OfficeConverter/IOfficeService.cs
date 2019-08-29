using Microestc.OfficeConverter.Events;

namespace Microestc.OfficeConverter
{
    public interface IOfficeService
    {
        void Convert(TaskSetup setup);
        void ConvertFinished(object sender, ConvertFinishedEventArgs args);
        void ConvertProgress(object sender, ConvertProgressEventArgs args);
    }
}