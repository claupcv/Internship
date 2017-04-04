using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    class ProcessResult
    {
        public bool StatusFlag { get; private set; }
        
        public string ErrorSuccesCode { get; private set; }

        public ProcessResult()
        {
            StatusFlag = false;
            ErrorSuccesCode = string.Empty;
        }

    }
}
