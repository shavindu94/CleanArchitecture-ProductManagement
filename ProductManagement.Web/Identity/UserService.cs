using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Identity
{
    public class UserService:IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _context;

        public UserService(UserManager<IdentityUser> userManager , IHttpContextAccessor context)
        {
            _userManager = userManager;
            _context = context;
        }

        public string GetLoggedUserId()
        {
            return _userManager.GetUserId(_context.HttpContext.User);
        }


    }
}
