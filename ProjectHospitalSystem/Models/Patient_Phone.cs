using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    [PrimaryKey(nameof(PatientId), nameof(PhoneNumber))]
    public class Patient_Phone
    {
        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }
        [ForeignKey("Patient")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
