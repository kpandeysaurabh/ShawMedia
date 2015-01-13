using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shaw.Models
{
    //This is a dummy data for testing purpose only..
    //TODO: Replace this class with proper Model based on Database repository
    public static class InMemoryData
    {
        public static List<Video> modelVideos = new List<Video>() 
        { 
            new Video{Id ="Video1", Title= "Video Title1", ShortDescription ="Video Short Desc 1", Timelines= "Video Timeline 1", Description="VideoFilePath1",ThumbnailPath="VideoThumbNailPath1"},
            new Video{Id ="Video2", Title= "Video Title2", ShortDescription ="Video Short Desc 2", Timelines= "Video Timeline 2", Description="VideoFilePath2",ThumbnailPath="VideoThumbNailPath2"},
            new Video{Id ="Video3", Title= "Video Title3", ShortDescription ="Video Short Desc 3", Timelines= "Video Timeline 3", Description="VideoFilePath3",ThumbnailPath="VideoThumbNailPath3"},
            new Video{Id ="Video4", Title= "Video Title4", ShortDescription ="Video Short Desc 4", Timelines= "Video Timeline 4", Description="VideoFilePath4",ThumbnailPath="VideoThumbNailPath4"}
        };

        public static List<Video> modelVideos1 = new List<Video>() 
        { 
            new Video{Id ="Video5", Title= "Video Title5", ShortDescription ="Video Short Desc 5", Timelines= "Video Timeline 5", Description="VideoFilePath5",ThumbnailPath="VideoThumbNailPath5"},
            new Video{Id ="Video6", Title= "Video Title6", ShortDescription ="Video Short Desc 6", Timelines= "Video Timeline 6", Description="VideoFilePath6",ThumbnailPath="VideoThumbNailPath6"},
            
        };

        public static List<Video> modelVideos2 = new List<Video>() 
        { 
            new Video{Id ="Video7", Title= "Video Title7", ShortDescription ="Video Short Desc 7", Timelines= "Video Timeline 7", Description="VideoFilePath7",ThumbnailPath="VideoThumbNailPath7"},
            new Video{Id ="Video8", Title= "Video Title8", ShortDescription ="Video Short Desc 8", Timelines= "Video Timeline 8", Description="VideoFilePath8",ThumbnailPath="VideoThumbNailPath8"}
        };

        public static List<Category> modelCategories = new List<Category>()
        {
            new Category{Id="Category1",Name="Category Name 1", Videos=modelVideos1},
            new Category{Id="Category2",Name="Category Name 2", Videos=modelVideos2}
        };

        public static List<Category> modelCategories3 = new List<Category>()
        {
            new Category{Id="Category3",Name="Category Name 3", Videos=modelVideos},
            
        };

        public static List<Show> modelShows = new List<Show>()
        {
            new Show{Id="Show1", Description="Show Description 1", Name="Show Name 1", Categories=modelCategories},
            new Show{Id="Show2", Description="Show Description 2", Name="Show Name 2", Categories=modelCategories3}
        };

        

        
    }
}