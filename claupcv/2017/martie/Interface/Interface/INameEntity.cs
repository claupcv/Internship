using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface INameEntity
    {
        string FirstName { get; }

        string LastName { get; }

        void ShowYourself();
    }
}
