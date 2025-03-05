using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required,MaxLength(50)]
        public string UserName { get; set; }
        [Required,MaxLength(50)]
        public string FName { get; set; }
        [Required,MaxLength(50)]
        public string LName { get; set; }
        [Required,MaxLength(50)]
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [MaxLength(30)]
        public string Role { get; set; }
        [ForeignKey("Bill")]
        public int? BillId { get; set; }
        [ForeignKey("Doctor")]
        public int? DoctorId { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual List<User_Phone>UserPhones { get; set; }

        
    }
}
