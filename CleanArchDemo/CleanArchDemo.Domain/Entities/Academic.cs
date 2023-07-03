using CleanArchDemo.Domain.Common;

namespace CleanArchDemo.Domain.Entities
{
    public sealed class Academic : GeneralData
    {
        public string? AcademicLevel { get; set; }
        public Subject Subject { get; set; }
    }
}