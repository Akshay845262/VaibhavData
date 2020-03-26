﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace MvcFilters.Infrastructure
{
    public class SiteAuthenticationAttribute : FilterAttribute,IAuthenticationFilter 
    {
        public void OnAuthentication(AuthenticationContext context)
        {
            IIdentity ident = context.Principal.Identity;
            if (!ident.IsAuthenticated || !ident.Name.EndsWith("@google.com"))
            {
                context.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext context)
        {
            if(context.Result==null|| context.Result is HttpUnauthorizedResult )
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"controller","SiteAccount" },
                    {"action","Login" },
                    {"returnUrl",context.HttpContext.Request.RawUrl }
                });
            }
            
        }
    }
}