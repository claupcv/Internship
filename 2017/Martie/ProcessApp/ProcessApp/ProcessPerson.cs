using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessApp
{
    public class ProcessPerson : ProcessFlow
    {
        public static int populationCount = 0;

        protected override bool StatusFlag { get; set; }

        protected override string ErrorSuccesCode { get; set; }

        public ProcessPerson()
        {
            this.StatusFlag = true;
            this.ErrorSuccesCode = string.Empty;
        }

        public override void ConsoleInputVerifyInputValue(Person person, string inputLabel, string type)
        {

            Console.Write("Input data:{0} = ", inputLabel);
            string inputConsole = Console.ReadLine();
            int num;
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
            else if (type.ToUpper() == "INT" && int.TryParse(inputConsole, out num) != true)
            {
                StatusFlag = false;
                this.ErrorSuccesCode = errorCodes.NotNumber.ToString();
            }
            else
            {
                StatusFlag = true;
                this.ErrorSuccesCode = SuccesfulCodes.TextOK.ToString();
            }
            if (StatusFlag == true)
            {
                person[inputLabel] = inputConsole;
            }

        }

        public override void OutputToConsole(string textOutput)
        {
            Console.WriteLine("Person NO. : {0} - PID : {1}", textOutput.ToString(), this.PID);
        }


        public override void Run(Person person, string inputField, string type)
        {
            Console.WriteLine("PROCESS PERSON");
            //person = null;
            if (person == null)
            {
                this.StatusFlag = false;
                this.ErrorSuccesCode = errorCodes.NullInstance.ToString();
            }

            if (this.StatusFlag == true)
            {
                this.ConsoleInputVerifyInputValue(person, "FirstName", FieldType.String.ToString());
            }
            if (this.StatusFlag == true)
            {
                this.ConsoleInputVerifyInputValue(person, "LastName", FieldType.String.ToString());
            }
            if (this.StatusFlag == true)
            {
                this.ConsoleInputVerifyInputValue(person, "Age", FieldType.Int.ToString());
            }

            if (this.StatusFlag == true)
            {
                OutputToConsole(Person.populationCount.ToString());
            }
            this.ErrorSuccesMessage(this.ErrorSuccesCode.ToString());
        }

        protected override void ErrorSuccesMessage(string errorCodeHandling)
        {
            Console.WriteLine(errorCodeHandling.ToString());
        }
    }
}
