using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebTasker.Models
{
    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            db.TaskList.Add(new Task { Name = "Complete task 1", Status = State.complited });
            db.TaskList.Add(new Task { Name = "Switch to task 2", Status = State.created });
            db.TaskList.Add(new Task { Name = "Start task 3", Status = State.created });

            base.Seed(db);
        }
    }
}