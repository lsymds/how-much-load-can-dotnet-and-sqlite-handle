using System;
using Microsoft.AspNetCore.Identity;

namespace HowMuchLoadCanNetHandle.App.Data;

public record Order : Entity 
{
    public Guid UserId { get; set; }
    
    public int Cost { get; set; }
    
    public int Discount { get; set; }
    
    public int Vat { get; set; }
    
    public int Total { get; set; }
    
    public bool Paid { get; set; }
    
    public IdentityUser User { get; set; }
}
