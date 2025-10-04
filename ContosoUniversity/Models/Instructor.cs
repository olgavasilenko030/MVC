using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        
        [Required]
        [Display(Name ="Фамилия")]
        [StringLength(24)]
        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Имя")]
        [StringLength(24)]
        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [Display(Name ="Работает с")]

        public DateTime HireDate { get; set; }
        [Display(Name ="Препод")]

        public string FuulName { get => $"{LastName}{FirstName}"; }
    }
}
