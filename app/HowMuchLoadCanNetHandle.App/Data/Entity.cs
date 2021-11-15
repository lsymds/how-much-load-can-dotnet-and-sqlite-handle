using System;

namespace HowMuchLoadCanNetHandle.App.Data;

public record Entity
{
    public Guid Id { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? DeletedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}
