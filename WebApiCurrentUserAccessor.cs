using Energetic.Security;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;

namespace Energetic.WebApis
{
    public class WebApiCurrentUserAccessor : ICurrentUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WebApiCurrentUserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public ClaimsPrincipal CurrentUser
        {
            get
            {
                return _httpContextAccessor.HttpContext.User;
            }
        }
    }
}