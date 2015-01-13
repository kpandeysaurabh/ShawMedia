using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shaw.Models;

namespace Shaw.Controllers
{
    public class CategoryController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage CreateCategory(string id, string name, string showId)
        {
            Category category = new Category();
            category.Id = id;
            category.Name = name;

            DataManager dataManager = new DataManager();
            dataManager.AddCategory(category, showId);

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.Created, category);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = category.Id }));

            return response;

        }
    }
}
