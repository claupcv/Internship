using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ProcessApp
{

    // FLORIN: Types should be in PascalCasing
    public enum errorCodes
    {
        //[Description("ERROR: Text is empty")]
        TextEmpty,

        //[Description("ERROR: Text has no visible text")]
        //FLORIN: Maybe rename to WhitespacesOnlyText
        WhitespacesOnlyText,

        //[Description("ERROR: Instance missing !!!")]
        InstanceMissing,

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
        //OBS : make abstract because it depends on the process, but cannot be readonly
        public readonly Guid PID;

        // FLORIN: move to another class, e.g.: ProcessResult
        protected abstract bool StatusFlag { get; set; }

        // FLORIN: move to another class, e.g.: ProcessResult
        protected abstract string ErrorSuccesCode { get; set; }

        public ProcessFlow()
        {
            this.PID = System.Guid.NewGuid();
        }


        // FLORIN: Not this class responsibility!
        public abstract void ConsoleInputVerifyInputValue(Person person, string inputLabel, string type);

        // FLORIN: Not this class responsibility!
        public abstract void OutputToConsole(string textOutput);

        //public abstract void Run(Person person);
        // FLORIN: Run should enforce the process flow
        public abstract void Run(Person person, string inputField, string type);

        // FLORIN: You can enforce the process flow this way:
        // 1) Define some abstract/virtual methods that correspond to each processing phase (Validation, Pre-Processing, Processing, Post-Processing)
        // 2) You compose the process flow in the Run method

        protected abstract void ErrorSuccesMessage(string errorCodeHandling);

        //protected abstract void ResultConsoleOutput(string output);


    }
}
