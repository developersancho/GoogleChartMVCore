using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleChartMVCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoogleChartMVCore.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("")]
        [Route("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                var product = new ProductViewModel();
                return Ok(product.findAll());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}