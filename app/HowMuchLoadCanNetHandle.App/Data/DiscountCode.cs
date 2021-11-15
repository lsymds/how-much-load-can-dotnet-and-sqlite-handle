using System;

namespace HowMuchLoadCanNetHandle.App.Data;

public record DiscountCode : Entity
{
    public string Code { get; set; }
    
    public DateTime ValidFrom { get; set; }
    
    public DateTime? ValidTo { get; set; }
    
    public int? DiscountPercentage { get; set; }
    
    public int? DiscountTotal { get; set; }
    
    public int? MinimumOrderValue { get; set; }
}
