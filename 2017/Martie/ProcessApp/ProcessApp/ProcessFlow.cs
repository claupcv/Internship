using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ProcessApp
{
    public enum errorCodes
    {
        //[Description("ERROR: Text is empty")]
        TextEmpty,

        //[Description("ERROR: Text has no visible text")]
        NoVisibleText,

        //[Description("ERROR: Instance missing !!!")]
        InstanceMissing,
        //[Description("ERROR: Instance missing !!!")]
        NotNumber,

        NoImput,

        NullInstance
    }
    public enum SuccesfulCodes
    {
        //[Description("PASSED: Text is good for processing")]
        TextOK
    }

    public enum FieldType
    {
        Int,
        String
    }

    public abstract class ProcessFlow
    {  
        public readonly Guid PID;

        protected abstract bool StatusFlag { get; set; }

        protected abstract string ErrorSuccesCode { get; set; }
                        
        public ProcessFlow()
        {            
            this.PID = System.Guid.NewGuid();
        }

        public abstract void ConsoleInputVerifyInputValue(string inputLabel, string type);
        public abstract void ConsoleInputVerifyInputValue(Person person, string inputLabel, string type);

        public abstract void OutputToConsole(string textOutput);

        public abstract void Run(Person person);
        public abstract void Run(string inputField, string type);

        protected abstract void ErrorSuccesMessage(string errorCodeHandling);

        //protected abstract void ResultConsoleOutput(string output);
        
        
    }
}
