using System;

namespace MethodToDelegate
{
    public class MethodBindingException : Exception
    {
        public MethodBindingException(string message) : base(message)
        {
        }
    }
}