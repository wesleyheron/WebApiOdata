using ApiODataMS.Data;
using ApiODataMS.Models;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiODataMS.Controllers
{
    public class ProductsController : ODataController
    {
        [EnableQuery]
        public IQueryable<Product> Get()
        {
            return ProductData.GetList().AsQueryable();
        }
    }
}
