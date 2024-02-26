using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    public class CustomersController
    {
        private readonly CustomerDAL _customerDAL;
        /// <summary>
        /// CustomersController constructor.
        /// 
        /// </summary>

        public CustomersController()
        {
            this._customerDAL = new CustomerDAL();
        }


        /// <summary>
        /// Get a list of customer.
        /// </summary>
        /// <returns>return list of customer</returns>
        public List<Customers> GetCustomers()
        {
            return this._customerDAL.GetCustomers();
        }
    }
}
