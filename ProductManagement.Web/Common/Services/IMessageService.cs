using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Common.Services
{
    public interface IMessageService
    {
        void SetMessage(Controller controller, string message, string type);

        void SetErrorMessage(Controller controller, string message, string type, string exception);
    }
}
