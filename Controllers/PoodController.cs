using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoodController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PoodController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Pood> GetProduct()
        {
            var product = _context.Pood.ToList();
            return product;
        }
        [HttpPost("add")]
        public List<Pood> PostProduct([FromBody] Pood product)
        {
            _context.Pood.Add(product);
            _context.SaveChanges();
            return _context.Pood.ToList();
        }
        [HttpDelete("delete/{id}")]
        public List<Pood> DeleteProduct(int id)
        {
            var product = _context.Pood.Find(id);

            if (product == null)
            {
                return _context.Pood.ToList();
            }

            _context.Pood.Remove(product);
            _context.SaveChanges();
            return _context.Pood.ToList();
        }
        [HttpGet("select/{id}")]
        public ActionResult<Pood> GetProduct(int id)
        {
            var product = _context.Pood.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPut("update/{id}")]
        public ActionResult<List<Pood>> PutProducts(int id, [FromBody] Pood updatedProduct)
        {
            var product = _context.Pood.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            product.PoodName = updatedProduct.PoodName;
            product.PoodAsukoht = updatedProduct.PoodAsukoht;
            product.ContactInfo = updatedProduct.ContactInfo;

            _context.Pood.Update(product);
            _context.SaveChanges();

            return Ok(_context.Pood);
        }
    }
}