using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Common.Enums
{
    public class MessageEnum
    {
        public enum MessageTypeEnum : int
        {
            None = 0,
            Success = 1,
            Error = 2,
            Warning = 3
        }
    }
}
