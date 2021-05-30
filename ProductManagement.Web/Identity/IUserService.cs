using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Identity
{
    public interface IUserService
    {
        string GetLoggedUserId();
    }
}
