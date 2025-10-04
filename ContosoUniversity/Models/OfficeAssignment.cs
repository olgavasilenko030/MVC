using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        public int InstructorID { get; set; }
        [StringLength(50)]
        [DisplayName("Office location")]

        public string Location { get; set; }

        // Navigation properties
        public Instructor Instructor { get; set; }
    }
}
