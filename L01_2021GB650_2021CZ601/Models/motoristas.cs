﻿using System.ComponentModel.DataAnnotations;
namespace L01_2021GB650_2021CZ601.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string? nombreMotorista { get; set; }
    }
}
