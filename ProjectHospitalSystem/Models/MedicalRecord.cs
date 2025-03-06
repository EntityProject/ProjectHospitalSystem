using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class MedicalRecord
    {
        [Key]
        public int MedicalId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dddd yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateOfVist { get; set; }
        [Required, MaxLength(150)]
        public string Diaqnois { get; set; }
        [Required, MaxLength(150)]
        public string Prescription { get; set; }
        [Required, MaxLength(200)]
        public string LabResult { get; set; }
        [Required, MaxLength(150)]
        public string TreatmentDetails { get; set; }
        [ForeignKey("Patient")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Doctor")]
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
