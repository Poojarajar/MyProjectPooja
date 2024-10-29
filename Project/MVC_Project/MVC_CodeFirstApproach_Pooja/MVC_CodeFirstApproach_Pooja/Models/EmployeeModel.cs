using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CodeFirstApproach_Pooja.Models
{
    [Table("tblEmployee")]
    public class EmployeeModel
    {
        [Key]
        public int id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string Job {  get; set; }
        public double Salary { get; set; }
    }
}
