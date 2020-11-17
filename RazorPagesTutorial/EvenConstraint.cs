﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTutorial
{
    public class EvenConstraint : IRouteConstraint
    {
        bool IRouteConstraint.Match(HttpContext httpContext, IRouter route, string routeKey, 
            RouteValueDictionary values, RouteDirection routeDirection)
        {
            int id;
            if(Int32.TryParse(values["id"].ToString(), out id))
            {
                return id % 2 == 0;

                //if(id%2 == 0)
                //{
                //    return true;
                //}

                //return false;
            }
            return false;
        }
    }
}
