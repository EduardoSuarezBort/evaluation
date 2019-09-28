using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace apiEvaluation.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiEvaluation.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<apiEvaluation.Models.Grade> Grades { get; set; }
    }
}