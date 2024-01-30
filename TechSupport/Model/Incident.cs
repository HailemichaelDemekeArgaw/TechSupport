using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
