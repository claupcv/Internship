using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class AbstractClassAndMethods
    {
        protected object Input { get; private set; }

        protected abstract bool IsInputValid();

        protected abstract object ExecuteAndReturnResult();

        public object Execute(object input)
        {
            this.Input = input;

            if (!this.IsInputValid())
            {
                return null;
            }

            var result = this.ExecuteAndReturnResult();

            return result;
        }
    }
}
