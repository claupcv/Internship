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

        SuccesfullRunProcess,

        GoodString,

        NoPersonCountException
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

        public abstract void ValidationProcess(ProcessResult processResult);

        public virtual void PreProcessingProcess(ProcessResult processResult)
        {
            processResult.StatusFlag = true;
        }

        public virtual void ProcessingProcess(ProcessResult processResult)
        {
            processResult.StatusFlag = true;
        }

        public virtual void PostProcessingProcess(ProcessResult processResult)
        {
            processResult.StatusFlag = true;
        }

        // FLORIN: Run should enforce the process flow
        public ProcessResult Run()
        {
            ProcessResult processResult = new ProcessResult();

            if (processResult.StatusFlag == true)
            {
                this.ValidationProcess(processResult);
            }
            if (processResult.StatusFlag == true)
            {
                this.PreProcessingProcess(processResult);
            }
            if (processResult.StatusFlag == true)
            {
                this.ProcessingProcess(processResult);
            }
            if (processResult.StatusFlag == true)
            {
                this.PostProcessingProcess(processResult);
            }

            return processResult;
        }

        // FLORIN: You can enforce the process flow this way:
        // 1) Define some abstract/virtual methods that correspond to each processing phase (Validation, Pre-Processing, Processing, Post-Processing)
        // 2) You compose the process flow in the Run method



        //protected abstract void ResultConsoleOutput(string output);

    }
}
