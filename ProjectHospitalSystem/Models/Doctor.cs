using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required, MaxLength(70)]
        public string Specialization { get; set; }
        [MaxLength(70)]
        public string? Email { get; set; }
        public int? DeptId { get; set; }
        [ForeignKey("DeptId")]
        public virtual Department Dept { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
        public virtual List<Doctor_Schedule> doctorSchedule { get; set; }
    }
}
