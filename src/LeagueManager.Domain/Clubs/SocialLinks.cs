using LeagueManager.Domain.MarkerInterfaces;

namespace LeagueManager.Domain.Clubs;

public record SocialLinks(
    string FacebookUrl,
    string TwitterUrl,
    string InstagramUrl,
    string YoutubeUrl) : IValueObject
{
    
}