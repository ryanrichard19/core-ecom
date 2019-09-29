using System;
using Ecom.Domain.Contacts.Handlers;
using Ecom.Domain.Contacts.Repositories;

namespace Ecom.BLL.Handlers
{
    public class ExceptionHandler: IExceptionHandler
    {
        private ILogger _logger;

        public ExceptionHandler(ILogger logger)
        {
            _logger = logger;
        }

        public T Run<T>(Func<T> func)
        {
            try
            {
                return func.Invoke();
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
            }
            return default(T);
        }
    }
}
