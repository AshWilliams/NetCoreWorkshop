using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabMVC.Controllers
{
    [Route("coolapi/products")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
               
        /// <summary>
        /// Endpoint por defecto, retorna lista de productos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Product> Get()
        {
            var productList = new List<Product>();
            var product1 = new Product
            {
                Name = "Arroz",
                Description = "Grano que se usa bastante en diversos platos"
            };
            var product2 = new Product
            {
                Name = "Mantequilla",
                Description = "Se usa bastante en diversos platos"
            };
            productList.Add(product1);
            productList.Add(product2);
            return productList;
        }

        // GET: api/Servicio/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Servicio
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Servicio/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
