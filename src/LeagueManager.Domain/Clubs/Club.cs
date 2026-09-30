using LeagueManager.Domain.MarkerInterfaces;

namespace LeagueManager.Domain.Clubs;

public class Club : BaseEntity, IAggregateRoot
{
    public string Name { get; private set; }
    public string PhotoUrl { get; private set; }
    public int FoundedYear { get; private set; }
    public string WebsiteUrl { get; private set; }
    public bool? IsDeleted { get; private set; }
    
    public SocialLinks Links { get; private set; }
    
    public Address Address {get; private set;}
    
    
    // Required for EF core
    private Club() { }

    private Club(string name, string photoUrl, int foundedYear, string websiteUrl)
    {
        Name = name;
        PhotoUrl = photoUrl;
        FoundedYear = foundedYear;  
        WebsiteUrl = websiteUrl;
    }

    public static Club Create(string name, string photoUrl, int foundedYear, string websiteUrl)
    {
        return new Club(name,  photoUrl, foundedYear, websiteUrl);
    }

    public void Update(string photoUrl, string websiteUrl)
    {
        PhotoUrl += photoUrl;
        WebsiteUrl += websiteUrl;
    }

    public void MarkAsDeleted()
    {
        IsDeleted = true;
    }

    public void UpdateAddress(Address address)
    {
        Address = address;
    }

    public void UpdateSocialLink(SocialLinks socialLinks)
    {
        Links = socialLinks;
    }
}