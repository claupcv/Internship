using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    public class ProcessString : ProcessFlow
    {
        private string Text { get; set; }
        private string Label { get; set; }

        public ProcessString()
            : this("", "")
        {

        }
        public ProcessString(string labelText)
            : this("", "")
        {

        }

        public ProcessString(string labelText, string text)
        {
            this.Label = labelText;
            this.Text = text;
        }

        public override void ValidationProcess(ProcessResult processResult)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                processResult.StatusFlag = false;
                processResult.ErrorSuccesCode = ErrorCodes.TextEmpty.ToString();
            }
            else if (string.IsNullOrWhiteSpace(this.Text))
            {
                processResult.StatusFlag = false;
                processResult.ErrorSuccesCode = ErrorCodes.WhitespacesOnlyText.ToString();
            }
            else
            {
                processResult.StatusFlag = true;
                processResult.ErrorSuccesCode = ErrorCodes.GoodString.ToString();
            }
        }

        public override void ProcessingProcess(ProcessResult processResult)
        {
            ConsoleInteratctiveMenu.ConsoleWrite(this.Label, this.Text + " " + base.PID.ToString());
            processResult.StatusFlag = true;
        }
    }
}
