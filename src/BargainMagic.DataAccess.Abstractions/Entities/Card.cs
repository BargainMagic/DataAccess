namespace BargainMagic.DataAccess.Abstractions.Entities
{
    public class Card
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool IsLegal { get; set; }
    }
}
