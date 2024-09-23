

namespace OneReview.Domain;

    public class Product
    {
        public Guid Id { get; set; }  = Guid.NewGuid(); 
                public required string Name { get; init; }
        public string Category { get; set; }    
        public string Subcategory { get; set; }     
         
    }
