using System.Runtime.InteropServices;

namespace FMS2.Controllers{
    public sealed class Constants{

        static Constants(){
            RecognizeOs();
        }
        public static string RootPath {get; set;}

        public const int DayCount = 10;

        public static string Tmp {get; set;}

        public static string OsName {get; set;}

        public const int MaxLogFileSize = 100 * 1024 * 1024;

        private static void RecognizeOs()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) OsName = OSPlatform.Windows.ToString();
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) OsName = OSPlatform.Linux.ToString();
        }

        
    }
}