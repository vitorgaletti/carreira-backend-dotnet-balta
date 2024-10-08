using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm(Url url, Campaign campaign)
{
    /// <summary>
    /// URL (Website Link)
    /// </summary>
    public Url Url { get; } = url;
    
    /// <summary>
    /// Campaign Details
    /// </summary>
    public Campaign Campaign { get; } = campaign;
}