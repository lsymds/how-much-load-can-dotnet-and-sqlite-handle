using System;

namespace HowMuchLoadCanNetHandle.App.Data;

public record ShortlistedProduct : Entity
{
    public Guid ProductId { get; set; }
    
    public Guid UserId { get; set; }

    public Product Product { get; set; }
}