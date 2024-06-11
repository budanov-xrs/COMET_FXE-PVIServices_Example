using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pluto_PVI_trial_01
{
    class Logger
    {

        public enum logLevelT {DEBUG, WARNING, INFO, ERROR}
        
        private logLevelT logLevel;
        private System.Windows.Forms.TextBox tbLog;
        private FileStream fs = null;
        private StreamWriter stwrLog;

        public Logger(System.Windows.Forms.TextBox guiLogger, string fileLoggerPath, logLevelT level=logLevelT.DEBUG)
        {
            logLevel = level;
            fs = new FileStream(fileLoggerPath, FileMode.Append);
            stwrLog = new StreamWriter(fs);
            stwrLog.AutoFlush = true;
            tbLog = guiLogger;
            
        }

        ~Logger()
        {
            fs.Dispose();
        }

        public void logMsg(logLevelT level, string msg)
        {
            if (level >= logLevel)
            {
                msg = DateTime.Now.ToString() + ", [" + level.ToString() +  "] : " + msg;
                tbLog.AppendText(msg + "\r\n");
                stwrLog.WriteLine(msg);
                
            }
        }
    }
}
