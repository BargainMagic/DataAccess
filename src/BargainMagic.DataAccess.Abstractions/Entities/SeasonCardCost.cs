namespace BargainMagic.DataAccess.Abstractions.Entities
{
    public class SeasonCardCost
    {
        public Guid SeasonId { get; set; }
        public Guid CardId { get; set; }
        public float Cost { get; set; }
    }
}
