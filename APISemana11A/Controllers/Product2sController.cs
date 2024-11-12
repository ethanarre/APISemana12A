using APISemana11A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APISemana11A.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Product2sController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public Product2sController(InvoiceContext context)
        {
            _context = context;
        }


        // OBTENER TODA LA LISTA
        [HttpGet]
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // BUSCAR POR NOMBRE
        [HttpGet]
        public List<Product> GetByName(string name)
        {
            return _context.Products.Where(x => x.Name.Contains(name)).ToList();
        }

        // CREACIÓN DE NUEVO PRODUCTO
        [HttpPost]
        public void Insert(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // EDITAR DATOS DEL PRODUCTO
        [HttpPut]
        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteById(int productID)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductID == productID);
            if (product != null)
            {
                product.Active = false;
                _context.SaveChanges();
            }
        }
    }

}
