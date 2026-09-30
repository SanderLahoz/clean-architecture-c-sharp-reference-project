namespace LeagueManager.Domain
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}