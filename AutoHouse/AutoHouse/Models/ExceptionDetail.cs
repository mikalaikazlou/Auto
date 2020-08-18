using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoHouse.Models
{
    public class ExceptionDetail
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string StackTrace { get; set; }
        public DateTime Date { get; set; }
    }
    public class LogContext : DbContext
    {
        public LogContext() : base("Logger") { }
        public DbSet<ExceptionDetail> exceptionDetails { get; set; }
    }

    public class InitializerExceptionLog : DropCreateDatabaseIfModelChanges<LogContext>
    {
        protected override void Seed(LogContext context)
        {
            base.Seed(context);
        }
    }
}