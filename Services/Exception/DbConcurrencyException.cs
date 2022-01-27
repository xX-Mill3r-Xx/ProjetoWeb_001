using System;

namespace ProjetoWebMVC.Services.Exception
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {
            
        }
    }
}