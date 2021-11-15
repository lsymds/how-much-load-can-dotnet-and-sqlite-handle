using System;

namespace HowMuchLoadCanNetHandle.App.Data;

public record Category : Entity
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string Slug { get; set; }
    
    public bool Visible { get; set; }
}
