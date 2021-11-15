using System;

namespace HowMuchLoadCanNetHandle.App.Data;

public record OrderItem : Entity
{
    public Guid ProductId { get; set; }
    
    public int Quantity { get; set; }
    
    public int Cost { get; set; }
    
    public int Vat { get; set; }
    
    public int Total { get; set; }
    
    public Product Product { get; set; }
}
