using LeagueManager.Domain.MarkerInterfaces;

namespace LeagueManager.Domain.Players;

public record PlayerStats(
    int Apperances,
    int Goals,
    int Assists) : IValueObject
{
    
}