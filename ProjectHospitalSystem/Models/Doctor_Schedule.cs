using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectHospitalSystem.Models
{
    [PrimaryKey(nameof(DoctorId), nameof(ScheduleDay))]
    public class Doctor_Schedule
    {
        public DateTime ScheduleDay { get; set; }
        [ForeignKey("Doctor")]
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
