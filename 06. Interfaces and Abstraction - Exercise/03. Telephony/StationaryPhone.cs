using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            Validator.ThrowIfNumberIsInvalid(number);
            return $"Dialing... {number}";
        }
    }
}
