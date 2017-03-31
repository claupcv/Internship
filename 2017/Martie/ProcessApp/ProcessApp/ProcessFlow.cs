using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ProcessApp
{

    // FLORIN: Types should be in PascalCasing - DONE
    public enum ErrorCodes
    {
        //[Description("ERROR: Text is empty")]
        TextEmpty,

        //[Description("ERROR: Text has no visible text")]
        //FLORIN: Maybe rename to WhitespacesOnlyText
        WhitespacesOnlyText,

        //[Description("ERROR: Instance missing !!!")]
        InstanceMissing,

        NotNumber,

        NoInput,

        NullInstance,

        SuccesfullRunProcess
    }

    public enum FieldType
    {
        Int,
        String
    }

    public abstract class ProcessFlow
    {        
        public readonly Guid PID;       

        public ProcessFlow()
        {
            this.PID = System.Guid.NewGuid();
        }

        protected abstract void ValidationProcess(object input);

        protected abstract void PreProcessingProcess(object input);

        protected abstract void ProcessingProcess(object input);

        protected abstract void PostProcessingProcess(object input);
        
        // FLORIN: Run should enforce the process flow
        public ProcessResult Run(Object objectProcess)
        {
            ProcessResult processResult = new ProcessResult();
            
            ValidationProcess(objectProcess);
            if (processResult.StatusFlag==true)
            {
                PreProcessingProcess(objectProcess);
            }
            if (processResult.StatusFlag == true)
            {
                ProcessingProcess(objectProcess);
            }
            if (processResult.StatusFlag == true)
            {
                PostProcessingProcess(objectProcess);
            }
            
            return processResult;
        }

        // FLORIN: You can enforce the process flow this way:
        // 1) Define some abstract/virtual methods that correspond to each processing phase (Validation, Pre-Processing, Processing, Post-Processing)
        // 2) You compose the process flow in the Run method

        protected abstract void ErrorSuccesMessage(string errorCodeHandling);

        //protected abstract void ResultConsoleOutput(string output);

    }
}
