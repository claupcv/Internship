using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    public class ProcessString : ProcessCore
    {
        public ProcessString() { }

        /// <summary>
        /// Run the process for string values 
        /// </summary>
        /// <param name="textString">Input string values</param>
        public void Run(string textString)
        {
            if (this.VerifyInputData(textString))
            {
                this.SuccesHandling(this.SuccesfulCode);

                this.DisplayOutputProcessdata(textString);
            }
            else
            {
                this.ErrorHandling(this.errorCode);
            }

        }
    }
}
