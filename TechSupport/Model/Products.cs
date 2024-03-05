using System.ComponentModel.DataAnnotations;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents a clas for modeling product information
    /// </summary>
    public class Products
    {
        [Key]
        public string ProductCode { get; set; }
        public string Name { get; set; }
       
    }
}
