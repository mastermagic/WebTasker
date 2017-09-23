using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace WebTasker.Helpers
{
    public class ListHelper
    {
        public static SelectList StateList()
        {
            return new SelectList(new[]
            {
                  new SelectListItem {Text="created",Value="created" },
                  new SelectListItem {Text="complited",Value="complited" },
                  new SelectListItem {Text="processed",Value="processed" }
            }, "Value", "Text");
        }

        public static SelectList CheckList()
        {
            return new SelectList(new[]
            {
                  new SelectListItem {Text="checked",Value="checked" },
                  new SelectListItem {Text="unchecked",Value="" }
            }, "Value", "Text");
        }
    }
}