using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Common.Services
{
    public class MessageService :IMessageService
    {
        private readonly ILogger<MessageService> _log;

        public MessageService(ILogger<MessageService> log)
        {
           _log = log;
        }


        public void SetMessage(Controller controller ,string message ,string type)
        {
            string logMessage = "";
            controller.TempData[type] = message;
            logMessage = message;
            _log.LogInformation(logMessage);

        }

        public void SetErrorMessage(Controller controller, string message, string type , string exception)
        {
            string logMessage = "";
            controller.TempData[type] = message;
            logMessage = message + "--- Exception : " + exception;
           _log.LogError(logMessage);

        }
    }
}
