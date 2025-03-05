using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd }", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [MaxLength(7)]
        public string Gender { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(70)]
        public string Address { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Patient_Phone> Patient_Phone { get; set; }
        public virtual List<Appointment> Appointment {  get; set; }


    }
}
