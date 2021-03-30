using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Employee
    {
        [Column(TypeName = "varchar(500)")]
        public int EmployeeId { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string EmployeeName { get; set; }
        [ForeignKey("DepartmentId")]
        public string Department { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string DateOfJoining { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string PhotoFileName { get; set; }
    }
}
