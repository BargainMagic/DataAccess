namespace BargainMagic.DataAccess.Abstractions.Entities
{
    public class Season
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateStamp { get; set; }
        public bool IsPublished { get; set; }
    }
}
