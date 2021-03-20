using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Logging
{
    public class SeriLogger:IMyLogger
    {
        public void Log(string message)
        {
            Serilog.Log.Information(message);
        }
    }
}
