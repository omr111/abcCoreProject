﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : ControllerBase
    {
        Business.Abstract.IproductBll _product;
        public Products(Business.Abstract.IproductBll product)
        {
            _product = product;
        }
        [HttpGet("getall")]
    
        public ActionResult getAll()
        {
            return Ok(_product.getAll());
        }
        [HttpGet("getone/{id}")]
        
        public ActionResult getone(int id)
        {
            return Ok(_product.getOneById(id));
        }
    }
}
