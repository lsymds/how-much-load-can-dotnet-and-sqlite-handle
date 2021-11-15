using System;
using System.Collections.Generic;

namespace HowMuchLoadCanNetHandle.App.Data;

public record Product : Entity
{
    public string Slug { get; set; }
    
    public string Name { get; set; }
    
    public int Stock { get; set; }
    
    public List<Category> Categories { get; set; }
    
    public List<ProductReview> Reviews { get; set; }
    
    public List<ProductPrice> Prices { get; set; }
}
