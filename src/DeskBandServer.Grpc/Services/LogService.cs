using System;
using System.IO;

namespace DeskBandServer.Grpc.Services
{
    public class LogService
    {
        #region Constructors

        public LogService()
        {
            var dir = Path.GetDirectoryName(GetType().Assembly.Location);
            LogFile = Path.Combine(dir, "DeskBandGrpc.log");
            ErrorLogFile = Path.Combine(dir, "error.log");
        }

        #endregion Constructors

        #region Properties

        public string ErrorLogFile { get; private set; }
        public string LogFile { get; private set; }

        #endregion Properties

        #region Methods

        public void Clear()
        {
            File.WriteAllText(LogFile, "");
        }

        public void Log(string content, string tag = "info")
        {
            try
            {
                File.AppendAllText(LogFile, $"{DateTime.Now} [{tag}] {content}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                try { File.AppendAllText(ErrorLogFile, ex.Message); } catch (Exception) { }
            }
        }

        public void LogError(string content)
        {
            try
            {
                File.AppendAllText(ErrorLogFile, $"{DateTime.Now} {content}{Environment.NewLine}");
            }
            catch (Exception) { }
        }

        #endregion Methods
    }
}