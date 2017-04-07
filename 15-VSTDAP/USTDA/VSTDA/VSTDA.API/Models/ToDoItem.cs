using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSTDA.API.Models
{
    public class TodoItem
    {
        public int ToDoItemID { get; set; }
        public string Item { get; set; }
        public int Priority { get; set; }
    }
}