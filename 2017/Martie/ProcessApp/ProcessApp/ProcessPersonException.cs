using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    class ProcessPersonException : ProcessPerson
    {
        public override void PostProcessingProcess(ProcessResult processResult)
        {
            throw new System.ArgumentException(ErrorCodes.NoPersonCountException.ToString() + " " + base.PID.ToString());
        }
    }
}
