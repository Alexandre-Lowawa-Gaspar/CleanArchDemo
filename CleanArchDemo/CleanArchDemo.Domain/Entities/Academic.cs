using CleanArchDemo.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchDemo.Domain.Entities
{
    public class Academic:GeneralData
    {
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string? AcademicLevel { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public Matter Subject { get; set; }
    }
}