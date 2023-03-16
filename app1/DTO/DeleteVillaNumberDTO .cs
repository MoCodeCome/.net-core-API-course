﻿using System.ComponentModel.DataAnnotations;

namespace app1.DTO
{
    public class DeleteVillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; }
    }
}
