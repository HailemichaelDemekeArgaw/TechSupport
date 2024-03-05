using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class SearchIncidentVM
    {
        public int IncidentId { get; set; }
        public int CustomerId { get; set; }
        public string ProductCode { get; set; }
        public int? TechId { get; set; }
        public DateTime DatedOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string? Title { get; set; }
        public string? Technician { get; set; }
        public string? Description { get; set; }
        public string Customer { get; set; }
    }
}
