using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    public class ProcessString : ProcessFlow
    {
        protected override bool StatusFlag { get; set; }

        protected override string ErrorSuccesCode { get; set; }

        private string Text { get; set; }

        public ProcessString()
        {
            this.StatusFlag = true;
            this.ErrorSuccesCode = string.Empty;
        }


        public string this[string propertyName]
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(propertyName))
                {
                    switch (propertyName.ToUpper())
                    {
                        case "TEXT":
                            return this.Text;
                    }
                }
                return null;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(propertyName))
                {
                    switch (propertyName.ToUpper())
                    {
                        case "TEXT":
                            this.Text = value;
                            break;
                    }
                }
            }
        }

        public override void OutputToConsole(string textOutput)
        {
            Console.WriteLine("Result : {0} - PID : {1}", textOutput.ToString(), this.PID);
        }

        public override void ConsoleInputVerifyInputValue(Person person, string inputLabel, string type)
        {
            Console.Write("Input data:{0} = ", inputLabel);
            string inputConsole = Console.ReadLine();
            this[inputLabel] = inputConsole;

            if (string.IsNullOrEmpty(inputConsole))
            {
                StatusFlag = false;
                this.ErrorSuccesCode = errorCodes.TextEmpty.ToString();
            }
            else if (string.IsNullOrWhiteSpace(inputConsole))
            {
                StatusFlag = false;
                this.ErrorSuccesCode = errorCodes.NoVisibleText.ToString();
            }
            else if (type == "int")
            {
                int num;
                if (int.TryParse(inputConsole, out num) != true)
                {
                    StatusFlag = false;
                    this.ErrorSuccesCode = errorCodes.NotNumber.ToString();
                }
            }
            else
            {
                StatusFlag = true;
                this.ErrorSuccesCode = SuccesfulCodes.TextOK.ToString();
            }
        }

        public override void Run(Person person, string inputField, string type)
        {

            Console.WriteLine("PROCESS STRING");

            this.ConsoleInputVerifyInputValue(null, inputField, type);
            if (this.StatusFlag == true)
            {
                this.OutputToConsole(this[inputField]);
            }
            this.ErrorSuccesMessage(this.ErrorSuccesCode.ToString());

        }
        protected override void ErrorSuccesMessage(string errorCodeHandling)
        {
            Console.WriteLine(errorCodeHandling.ToString());
        }

    }
}
