using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class Incidents
    {
        public int IncidentID { get; set; }
        public int CustomerId { get; set; }
        public string ProductCode { get; set; }
        public int TechId { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }



    }
}
