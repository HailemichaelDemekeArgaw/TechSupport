using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class OpenIncidentsVM
    {
        public string ProductCode { get; set; }
        public string DatedOpened { get; set; }
        public string Customer { get; set; }
        public string? Title { get; set; }
        public string? Technician { get; set; }
    }
}
