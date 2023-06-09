﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Team.Models
{
    public class AssetRentLog
    {
        [Key]
        [Required]
        [ForeignKey("Asset_ID")]
        public Guid Asset_ID { get; set; }
        public float Asset_Cost { get; set;}
        [Key]
        [Required]
        [ForeignKey("Client_ID")]
        public Guid Client_ID { get; set; }
        public string Date { get; set;}
    }
}
