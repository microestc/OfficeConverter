using OfficeConverter.Events;
using System;
using System.Text.RegularExpressions;

namespace OfficeConverter
{
    public class OfficeProgress
    {
        private readonly Action<ConvertProgressEventArgs> ProgressCallback;
        private TimeSpan _totalDuration = TimeSpan.FromMilliseconds(1.0);
        private TimeSpan _processed = TimeSpan.FromMilliseconds(0.0);

        public OfficeProgress(Action<ConvertProgressEventArgs> progressCallback)
        {
            ProgressCallback = progressCallback;
        }

        public void ParseLine(string line)
        {
            if (string.IsNullOrEmpty(line))
                return;
            if (_totalDuration == TimeSpan.FromMilliseconds(1.0))
                TryGetDuration(line);
            FetchIsComplete(line);
        }

        private void TryGetDuration(string line)
        {
        }

        private void FetchProgress(string line)
        {

            ProgressCallback(new ConvertProgressEventArgs(_totalDuration, _processed, false));
        }

        private void FetchDuration()
        {
            ProgressCallback(new ConvertProgressEventArgs(_totalDuration, _processed, true));
        }

        private void FetchIsComplete(string line)
        {
            if (!line.Contains("->"))
                return;
            ProgressCallback(new ConvertProgressEventArgs(_totalDuration, _processed, false, true));
        }
    }
}
