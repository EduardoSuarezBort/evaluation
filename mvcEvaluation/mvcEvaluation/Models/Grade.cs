using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcEvaluation.Models
{
    public enum TypeStatus
    {
        aprobado,
        reprobado
    }
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        [Required]
        public int Nota { get; set; }
        [Required]
        public TypeStatus Status { get; set; }

        public virtual Student Student { get; set; }

    }
}