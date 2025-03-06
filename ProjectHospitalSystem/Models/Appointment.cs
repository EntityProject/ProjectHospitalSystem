using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dddd yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentDateTime { get; set; }
        [Required, MaxLength(30)]
        public string Status { get; set; }
        [Required, MaxLength(150)]
        public string Note { get; set; }
        public bool ReminderSent { get; set; } = false;
        [ForeignKey("Patient")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Doctor")]
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual List<Bill> Bill { get; set; }

    }
}
