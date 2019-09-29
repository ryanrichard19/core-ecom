using System;
using Ecom.Domain.Contacts.Repositories;

namespace Ecom.BLL.Managers
{
    public class Logger: ILogger
    {

        public void Log(Exception ex)
        {
            throw new Exception(ex.Message, ex.InnerException);
        }
    }
}
