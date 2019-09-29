using System;

namespace Ecom.Domain.Contacts.Repositories
{

    public interface ILogger
    {
        void Log(Exception ex);
    }
}
