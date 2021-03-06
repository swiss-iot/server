﻿using System.ComponentModel.DataAnnotations;

namespace SensorsManager.Web.Api.Models
{
    public class MeasurementModel
    {
        [MaxLength(50)]
        [Required]
        public string UnitOfMeasure { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
    }
}