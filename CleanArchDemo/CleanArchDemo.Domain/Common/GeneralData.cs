using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.Common
{
    public abstract class GeneralData
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O campo é obrigatório")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="O campo deve conter de 3 à 100 caracteres")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo deve conter de 3 à 100 caracteres")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "O campo deve conter de 3 à 10 caracteres")]
        public string? Abbreviation { get; set; }

    }
}

