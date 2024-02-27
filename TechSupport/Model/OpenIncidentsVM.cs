namespace TechSupport.Model
{
    /// <summary>
    /// Class repesenting open incidnets
    /// </summary>
    public class OpenIncidentsVM
    {
        public string ProductCode { get; set; }
        public string DatedOpened { get; set; }
        public string Customer { get; set; }
        public string? Title { get; set; }
        public string? Technician { get; set; }
    }
}
