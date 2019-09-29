using System;
namespace Ecom.Domain.Contacts.Handlers
{
    public interface IExceptionHandler
    {
        T Run<T>(Func<T> func);
    }
}
