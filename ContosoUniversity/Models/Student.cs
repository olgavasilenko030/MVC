using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        [Required]
        public int ID { get; set; }
        [DisplayName("Фамилия")]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-z]*$")]

        [Required]
        public string LastName { get; set; }
        [Display(Name="Имя")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Дата поступления")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; } // Дата поступления
        
        ///Calculated property
        [DisplayName("Студент")]
        public string FullName { get=>$"{LastName} {FirstName}"; }
        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Navigation properties
        public ICollection <Enrollment> Enrollments { get; set; }
    }
}
