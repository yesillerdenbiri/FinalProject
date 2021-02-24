using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Gevşek bağlılık loosely coupled
        //naming convention
        //IoC--Inversion of Controler
        IProductService _productService;

        public ProductsController(IProductService productService) //somut referans lazım
        {
            _productService = productService;
        }

        [HttpGet("getall")]  //çağırırken bu isimlendirmeler kolaylık sağlar
        public IActionResult GetAll()
        {
            //Bağımlılık zinciri
            
            var result=_productService.GetAll();
            if (result.Success)
            {
                return Ok(result); 
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")] //isimlerle alyans veriyoruz
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product) //post'u add yaptık
        {
           var result = _productService.Add(product);
           if (result.Success)
            {
                return Ok(result);
            }
           return BadRequest(result);
        }
    }
} // ürün çekerken get ürün eklerken post yani add kullanıyoruz. Postmanda
  //silme ve güncelleme için de http post kullanılabilir. veya http delete httpupdate 
