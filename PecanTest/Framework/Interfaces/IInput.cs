using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Framework.Interfaces
{
    interface IInput
    {
        String SendKeysToInput(int charsNumber);
        void CheckMaxChars();
    }
}
