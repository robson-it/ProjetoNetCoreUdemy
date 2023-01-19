using System;


namespace WebVendas.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException (string message) : base(message)
        {

        }
    }
}
