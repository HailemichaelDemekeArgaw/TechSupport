using TechSupport.DAL;
using TechSupport.Model;


namespace TechSupport.Controller
{
    /// <summary>
    /// Class representing the product controller
    /// </summary>
    public class ProductsController
    {
        private readonly ProductDAL _productDAL;
        public ProductsController()
        {
            this._productDAL = new ProductDAL();
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public List<Products> GetProducts()
        {
            return this._productDAL.GetProducts();
        }

    }
}
