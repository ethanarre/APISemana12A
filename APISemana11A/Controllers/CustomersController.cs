using APISemana11A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APISemana11A.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public CustomersController(InvoiceContext context)
        {
            _context = context;
        }


        //OBTENER TODA LA LISTA
        [HttpGet]
        public List<Customer> GetAll() 
        { 
            return _context.Customers.ToList();
        }

        //BUSCAR POR NOMBRE
        [HttpGet]
        public List<Customer> GetByFistName(string fistName) 
        {
            return _context.Customers.Where(x => x.FirstName.Contains(fistName)).ToList();
        }

        //CREACION DE NUEVO CUSTOMER
        [HttpPost]
        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        //EDITAR DATOS DEL CUSTOMER
        [HttpPut]
        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();

        }

        //ELIMINAR CUSTOMER
        [HttpDelete]
        public void DeleteById(int CustomerID) 
        {
            var customer = _context.Customers.Where(x=>x.CustomerID == CustomerID).FirstOrDefault();
            if(customer != null)
            {
                customer.Active = false;
                _context.SaveChanges();
            }

        }
    }
}
