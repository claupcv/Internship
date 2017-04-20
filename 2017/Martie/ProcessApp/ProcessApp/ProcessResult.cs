using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    public class ProcessResult
    {
        public bool StatusFlag;

        public string ErrorSuccesCode;

        public ProcessResult()
        {
            StatusFlag = true;
            ErrorSuccesCode = string.Empty;
        }

        public void ErrorSuccesMessage()
        {
            Console.WriteLine(this.ErrorSuccesCode);
        }

    }
}
