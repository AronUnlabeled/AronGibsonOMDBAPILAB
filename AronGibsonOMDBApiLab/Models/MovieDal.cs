using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AronGibsonOMDBApiLab.Models
{
    public class MovieDAL
    {
        public MovieModel GetMovie(string t) {
            string url = $"http://www.omdbapi.com/?apikey=7caabe36&t={t}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();
            MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(JSON);
            return movie;
        }
    }
}
