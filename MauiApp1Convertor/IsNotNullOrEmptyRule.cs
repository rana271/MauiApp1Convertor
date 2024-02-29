using Plugin.ValidationRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1Convertor
{
    public class IsNotNullOrEmptyRule<T> : IValidationRule<string>
    {
        public string ValidationMessage { get; set; }
        public bool Check(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
