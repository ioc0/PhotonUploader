using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.GData.Extensions;
using Google.GData.YouTube;
using Google.GData.Extensions.MediaRss;
using Google.YouTube;
using Google.GData.Client;

namespace PhotonUploader
{
    class Youtube
    {
        public string UploadVideo(string FilePath, string login, string pass)
        {
            YouTubeRequestSettings settings;
            YouTubeRequest request;
            string devkey = "AIzaSyBpnMoS7u_tT8HISPsj44tMYcs2c_JZnHs";
            string username = login;
            string password = pass;
            settings = new YouTubeRequestSettings("Your Application Name", devkey, username, password) { Timeout = -1 };
            request = new YouTubeRequest(settings);

            Video newVideo = new Video();

            newVideo.Title = "Test";
            newVideo.Description = "Test Description";
            newVideo.Private = true;
            newVideo.YouTubeEntry.Private = false;

            //newVideo.Tags.Add(new MediaCategory("Autos", YouTubeNameTable.CategorySchema));

            //newVideo.Tags.Add(new MediaCategory("mydevtag, anotherdevtag", YouTubeNameTable.DeveloperTagSchema));

            //newVideo.YouTubeEntry.setYouTubeExtension("location", "Paris, FR");
            // You can also specify just a descriptive string ==>
            // newVideo.YouTubeEntry.Location = new GeoRssWhere(71, -111);
            // newVideo.YouTubeEntry.setYouTubeExtension("location", "Paris, France.");

            newVideo.YouTubeEntry.MediaSource = new MediaFileSource(FilePath, "video/mp4");
            
            Video createdVideo = request.Upload(newVideo);

            return createdVideo.VideoId;
        }
    }
}
