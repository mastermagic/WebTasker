using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebTasker.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> TaskList { get; set; }
    }
}