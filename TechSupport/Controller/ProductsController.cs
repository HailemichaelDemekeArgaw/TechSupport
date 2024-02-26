using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;


namespace TechSupport.Controller
{
    public class ProductsController
    {
        private readonly ProductDAL _productDAL;
        public ProductsController()
        {
            this._productDAL = new ProductDAL();
        }

        public List<Products> GetProducts()
        {
            return this._productDAL.GetProducts();
        }

    }
}
