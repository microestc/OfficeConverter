using OfficeConverter.Events;

namespace OfficeConverter
{
    public interface IOfficeService
    {
        void Convert(TaskSetup setup);
        void ConvertFinished(object sender, ConvertFinishedEventArgs args);
        void ConvertProgress(object sender, ConvertProgressEventArgs args);
    }
}