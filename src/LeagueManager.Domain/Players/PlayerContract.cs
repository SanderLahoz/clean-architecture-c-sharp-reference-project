using LeagueManager.Domain.MarkerInterfaces;

namespace LeagueManager.Domain.Players;

public record PlayerContract (
    Guid ClubId,
    DateTime? StartDate,
    DateTime? EndDate,
    int SalaryPerMonth) : IValueObject
{
    
}