using System;

namespace Business.CCS
{
    public partial class FileLogger
    {
        public class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Dosyaya loglandı.");
            }
        }
    }
}
