using CleanArchDemo.Domain.Common;

namespace CleanArchDemo.Domain.Entities
{
    public sealed class Student : GeneralData
    {
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public Enrollment Matriculation { get; set; }
    }
}