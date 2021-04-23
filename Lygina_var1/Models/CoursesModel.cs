using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lygina_var1.Models
{
    public class CoursesModel
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReceiveDate { get; set; }
        public DateTime ExamDate { get; set; }
        public decimal Grade { get; set; }
        public int CommitteeId { get; set; }
    }
}
