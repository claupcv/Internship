using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ProcessApp
{
    /// <summary>
    /// Run process Core
    /// </summary>
    public class ProcessCore
    {
        public readonly Guid PID;

        public bool statusFlag { get; set; }

        protected string errorCode { get; set; }

        protected string SuccesfulCode { get; set; }

        /// <summary>
        /// initialize values in CTOR
        /// </summary>
        public ProcessCore()
        {
            statusFlag = false;
            errorCode = string.Empty;
            SuccesfulCode = string.Empty;
            PID = System.Guid.NewGuid();

        }

        /// <summary>
        /// Verifying the string valuie that have inputed
        /// </summary>
        /// <param name="text">String to be inputed</param>
        /// <returns>Bool - Status of validation</returns>
        protected bool VerifyInputData(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                this.statusFlag = false;
                this.errorCode = "String is empty";
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                this.statusFlag = false;
                this.errorCode = "String has no visible text";
            }
            else
            {
                this.statusFlag = true;
                this.SuccesfulCode = "String is good for processing";
            }
            return statusFlag;
        }


        protected void DisplayOutputProcessdata(string text)
        {
            Console.WriteLine(text.ToString());
        }

        protected void ErrorHandling(string errorCodeHandling)
        {
            if (this.statusFlag == false)
            {
                Console.WriteLine(errorCodeHandling.ToString() + ", PID:{0}", this.PID);
            }
        }
        protected void SuccesHandling(string SuccesfulCodeHandling)
        {
            if (this.statusFlag == true)
            {
                Console.WriteLine(SuccesfulCodeHandling.ToString() + ", PID:{0}", this.PID);
            }
        }
        public void Run()
        {
            ErrorHandling("No argument present!!!");
        }
    }

}
