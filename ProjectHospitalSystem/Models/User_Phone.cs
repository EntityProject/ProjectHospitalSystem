﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    [PrimaryKey(nameof(UserId), nameof(PhoneNumber))]
    public class User_Phone
    {
        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
