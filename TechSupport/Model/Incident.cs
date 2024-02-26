namespace TechSupport.Model
{
    /// <summary>
    /// Represents an incident entity with properties for title, description, and customer ID.
    /// </summary>
    public class Incident
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public string ProductCode { get; set; }
        public int TechId { get; set; }
        public DateTime DateOpened { get; set; }


    }
}
