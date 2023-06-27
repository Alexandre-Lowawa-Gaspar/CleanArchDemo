﻿using CleanArchDemo.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchDemo.Domain.Entities
{
    public class Coordination:GeneralData
    {
        [Required(ErrorMessage = "O campo é obrigatório")]
        public Academic Teacher { get; set; }

    }
}