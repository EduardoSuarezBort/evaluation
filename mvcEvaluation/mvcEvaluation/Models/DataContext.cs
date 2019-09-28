using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcEvaluation.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mvcEvaluation.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<mvcEvaluation.Models.Grade> Grades { get; set; }
    }
}