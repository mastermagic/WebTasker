using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTasker.Models
{
    public enum State
    {
        created,
        complited,
        processed
    }

    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public State Status { get; set; }
        public string Check { get; set; }
    }
}