using System;
using System.IO;
using System.Reflection;

namespace TwoBaslerCamera.Controllers
{
    public class LogWriter
    {
        public LogWriter()
        {

        }

        private string m_exePath = string.Empty;
        public LogWriter(string logMessage)
        {
            LogWrite(logMessage);
        }
        public void LogWrite(string logMessage)
        {
            // m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            m_exePath = Path.GetFullPath(Path.Combine(path, @"..\..\"));

            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log_output.txt"))
                {
                    string currentDate = DateTime.Now.ToString("dd_MMM_yyyy");
                    string hhmm = DateTime.Now.ToString("HH_mm");//12_59

                    Log( logMessage, w);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Exception: {0}", ex.Message);
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
               // txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}  {2}", DateTime.Now.ToLongTimeString(),
                 DateTime.Now.ToLongDateString(), logMessage);
                //txtWriter.WriteLine("  :{0}", logMessage);

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}