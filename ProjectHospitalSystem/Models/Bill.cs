using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dddd yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)] 
        public DateTime GenertedDate{ get; set; }
        [DisplayFormat(DataFormatString = "{0:dddd yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        [Required,Column(TypeName ="money")]
        public decimal TotalAmount { get; set; }
        [Required, MaxLength(20)]
        public string Status { get; set; }
        [ForeignKey("Appointment")]
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual List<Payment> Payment { get; set; }
    }
}
