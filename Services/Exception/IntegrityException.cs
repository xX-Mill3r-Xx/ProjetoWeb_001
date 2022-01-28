using System;

namespace ProjetoWebMVC.Services.Exception
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
            
        }
    }
}