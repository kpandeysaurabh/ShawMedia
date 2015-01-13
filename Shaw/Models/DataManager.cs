using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shaw.Models
{
    public class DataManager
    {
        //TODO: Update function to handle database repository changes
        public void AddVideo(Video video, string categoryId)
        {
            Category category = (from f in InMemoryData.modelCategories where f.Id == categoryId select f).FirstOrDefault();
            category.Videos.Add(video);

        }

        //TODO: Update function to handle database repository changes
        public void AddCategory(Category category, string showId)
        {
            Show show = (from f in InMemoryData.modelShows where f.Id == showId select f).FirstOrDefault();
            show.Categories.Add(category);

        }

        //TODO: Update function to handle database repository changes
        public void AddShow(Show show)
        {

            InMemoryData.modelShows.Add(show);

        }


        //TODO: Update function to handle database repository changes
        public void DeleteShow(string showId)
        {

            Show show = (from f in InMemoryData.modelShows where f.Id == showId select f).FirstOrDefault();
            InMemoryData.modelShows.Remove(show);


        }

        //TODO: Update function to get data from database repository
        public Show GetShow(string showId)
        {

            return (from f in InMemoryData.modelShows where f.Id == showId select f).FirstOrDefault();
   
        }
        //TODO: Update function to get data from database repository
        public List<Show> GetShow()
        {

            return InMemoryData.modelShows;

        }
    }
}