using Shaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shaw.Controllers
{
    public class VideoController : ApiController
    {
        

        [HttpPost]
        public HttpResponseMessage CreateVideo(string id, string title, string shortDescription, string timelines, string description, string filePath, string thumbnailPath, string categoryId)
        {
            Video video = new Video();
            video.Id = id;
            video.Title = title;
            video.ShortDescription = shortDescription;
            video.Timelines = timelines;
            video.Description = description;
            video.FilePath = filePath;
            video.ThumbnailPath = thumbnailPath;

            
            DataManager dataManager = new DataManager();
            dataManager.AddVideo(video, categoryId);
            

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.Created, video);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = video.Id }));

            return response;

        }

        

        
        
    }
}
