using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VSTDA.API.Models;

namespace VSTDA.API.Data
{
    public class VSTDADataContext : DbContext
    {
        // Constructor
        public VSTDADataContext() : base ("VSTDA")
        {

        }

        // DbSets (table)
        public IDbSet<TodoItem> TodoItems { get; set; }
    }
}