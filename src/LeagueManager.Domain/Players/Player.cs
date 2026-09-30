using LeagueManager.Domain.MarkerInterfaces;

namespace LeagueManager.Domain.Players;

public class Player : BaseEntity, IAggregateRoot
{
    public string Name { get; private set; }
    public int? ShirtNo { get; private set; }
    public DateTime? Birthdate { get; private set; }
    public int? HeightInCm { get; private set; }
    public string PhotoUrl { get; private set; }
    public string WebsiteUrl { get; private set; }
    public bool IsDeleted { get; private set; }
    
    public PlayerPosition Position { get; private set; }
    
    public PlayerStats Stats { get; private set; }
    
    public PlayerContract Contract { get; private set; }
}