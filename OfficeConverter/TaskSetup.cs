using System;
using System.Runtime.InteropServices;

namespace OfficeConverter
{
    public class TaskSetup
    {
        public TaskSetup(string id, string source, string outDir, string mark = "")
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Executable = "soffice.exe";
                Variate = "";
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                Executable = "libreoffice";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                Executable = "libreoffice";
            Id = id;
            Source = source;
            OutDir = outDir;
            Mark = mark;
        }

        public TaskSetup(string id, string cmd)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Executable = "soffice.exe";
                Variate = "";
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                Executable = "libreoffice";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                Executable = "libreoffice";
            Id = id;
            Cmd = cmd;
        }

        public string Id { get; private set; }

        public string Source { get; private set; }

        public string OutDir { get; private set; }

        public string Mark { get; private set; }

        private string Cmd { get; set; }

        public string Executable { get; }

        private string Variate { get; set; } = "";

        public Action<TaskSetup> CompletedCallBack { get; set; }

        internal string GetCmdLineParams()
        {
            if (!string.IsNullOrWhiteSpace(Cmd))
            {
                return Variate + " " + Cmd;
            }
            return $"{Variate} --invisible --convert-to pdf:writer_pdf_Export --outdir {OutDir} {Source}";
        }
    }
}
