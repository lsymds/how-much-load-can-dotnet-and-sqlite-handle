using System;
using Microsoft.AspNetCore.Identity;

namespace HowMuchLoadCanNetHandle.App.Data;

public record ProductReview : Entity
{
    public bool Approved { get; set; }
    
    public Guid ProductId { get; set; }
    
    public Guid UserId { get; set; }
    
    public int Rating { get; set; }
    
    public string Comments { get; set; }
    
    public DateTime PurchaseDate { get; set; }

    public Product Product { get; set; }
    
    public IdentityUser User { get; set; }
}
