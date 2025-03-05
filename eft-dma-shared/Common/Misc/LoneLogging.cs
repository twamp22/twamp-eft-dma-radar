using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace eft_dma_shared.Common.Misc
{
    public static class LoneLogging
    {
        private static StreamWriter _writer;

        static LoneLogging()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args?.Contains("-logging", StringComparer.OrdinalIgnoreCase) ?? false)
            {
                string logFileName = $"log-{DateTime.UtcNow.ToFileTime().ToString()}.txt";
                var fs = new FileStream(logFileName, FileMode.Create, FileAccess.Write);
                _writer = new StreamWriter(fs, Encoding.UTF8, 0x1000);
                AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
            }
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            var writer = Interlocked.Exchange(ref _writer, null);
            writer?.Dispose();
        }

        /// <summary>
        /// Write a message to the log with a newline.
        /// </summary>
        /// <param name="data">Data to log. Calls .ToString() on the object.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLine(object data)
        {
            Debug.WriteLine(data);
            _writer?.WriteLine(data.ToString()); // no-op'd if not enabled
        }
    }
}
