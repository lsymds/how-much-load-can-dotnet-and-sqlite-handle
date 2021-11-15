using System;

namespace HowMuchLoadCanNetHandle.App.Data;

public record ProductPrice : Entity
{
    public Guid ProductId { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public bool SpecialOffer { get; set; }
    
    public int Price { get; set; }
    
    public int? PreviousPrice { get; set; }
    
    public Product Product { get; set; }
}
