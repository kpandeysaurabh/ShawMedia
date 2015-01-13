using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shaw.Models;

namespace Shaw.Controllers
{
    public class ShowController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CreateShow(Show show)
        {
            if (!this.ModelState.IsValid)
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest));

            DataManager dataManager = new DataManager();
            dataManager.AddShow(show);

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.Created, show);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = show.Id }));

            return response;

        }


        public HttpResponseMessage DeleteShow(string Id)
        {
            DataManager dataManager = new DataManager();
            dataManager.DeleteShow(Id);
            return this.Request.CreateResponse(HttpStatusCode.NoContent);

        }

        public Show GetShowData(string Id)
        {
            DataManager dataManager = new DataManager();
            return dataManager.GetShow(Id);

        }

        public IEnumerable<Show> GetShowData()
        {
            DataManager dataManager = new DataManager();
            return dataManager.GetShow();

        }
    }
}
