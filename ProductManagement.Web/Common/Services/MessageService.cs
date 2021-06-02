using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProductManagement.Web.Common.Enums.MessageEnum;

namespace ProductManagement.Web.Common.Services
{
    public class MessageService :IMessageService
    {
        private readonly ILogger<MessageService> _log;

        public MessageService(ILogger<MessageService> log)
        {
           _log = log;
        }


        public void SetMessage(Controller controller ,string message , int messageType)
        {
            if(messageType == (int)MessageTypeEnum.Success)
            {
                controller.TempData["Success"] = message;
            }
            else if(messageType == (int)MessageTypeEnum.Warning)
            {
                controller.TempData["Warning"] = message;
            }

            _log.LogInformation(message);

        }

        public void SetErrorMessage(Controller controller, string message, string exception)
        {
            string logMessage = "";
            controller.TempData["Error"] = message;
            logMessage = message + "--- Exception : " + exception;
           _log.LogError(logMessage);

        }
    }
}
