using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm
{
    public Url url { get; set; }
    public Campaign Campaign { get; set; }
}