using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller class for the Technicians
    /// </summary>
    public class TechniciansController
    {
        private readonly TechniciansDAL _techniciansDAL;
        public TechniciansController()
        {
            this._techniciansDAL = new TechniciansDAL();
        }

        /// <summary>
        /// Gets the technicians.
        /// </summary>
        /// <returns></returns>
        public List<Technicians> GetTechnicians()
        {
            return this._techniciansDAL.GetTechnicians();
        }
    }
}
