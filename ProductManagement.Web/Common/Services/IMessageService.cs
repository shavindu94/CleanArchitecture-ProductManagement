using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Common.Services
{
    public interface IMessageService
    {
        void SetMessage(Controller controller, string message, int messageType);

        void SetErrorMessage(Controller controller, string message, string exception);
    }
}
