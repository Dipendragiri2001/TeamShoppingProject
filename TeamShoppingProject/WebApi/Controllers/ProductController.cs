using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.EFCore;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationContext context;

      
        public ProductController(IUnitOfWork unitOfWork,ApplicationContext context)
        {
            _unitOfWork = unitOfWork;
            this.context = context;
        }
        public IActionResult GetPopularProducts ([FromQuery]int count)
        {
            var popularProducts = _unitOfWork.Products.GetPopularProducts(count);
            return Ok(popularProducts);
        }
        [HttpPost]
        public IActionResult AddProduct()
        {
            var product = new Product
            {
                ProductName = "momo",
                Price = 100
            };
            context.Products.Add(product);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
