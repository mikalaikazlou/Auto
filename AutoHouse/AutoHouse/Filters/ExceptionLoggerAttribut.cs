using AutoHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoHouse.Filters
{
    public class ExceptionLoggerAttribut : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            ExceptionDetail exception = new ExceptionDetail
            {
                Message = filterContext.Exception.Message,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                StackTrace = filterContext.Exception.StackTrace,
                Date = DateTime.Now

            };
            using (LogContext logContext =new LogContext())
            {
                logContext.exceptionDetails.Add(exception);
                logContext.SaveChanges();
            }
            filterContext.ExceptionHandled = true;
        }
    }
}