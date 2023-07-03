namespace CleanArchDemo.Domain.Common
{
    public abstract class GeneralData
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public string? Abbreviation { get; set; }
    }
}