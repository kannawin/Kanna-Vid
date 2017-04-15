using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Web.Helpers;
using System.Threading;
using RestSharp.Serializers;
using System.IO;
using Microsoft.CSharp.RuntimeBinder;


namespace Movie_Info
{
    public class Info
    {
        private const string api_key = "97e4335bd73002b6731fc902f3748e96";
        private const string poster_first = "https://Image.tmdb.org/t/p/w300_and_h450_bestv2";

        public movObj movInfo(String title, movObj m)
        {
            string prepare = "";

            string movTitle = m.title;
            string year = m.year;

            if (movTitle.Contains("&"))
            {
                movTitle = movTitle.Replace("&", "and");
            }
            try
            {
                prepare = String.Format("https://api.themoviedb.org/3/search/movie?year={0}&include_adult=false&page=1&query={1}&language=en-US&api_key={2}", year, movTitle, api_key);
                dynamic returned = restRequest(prepare);

                if (returned.total_results > 0)
                {
                    //initialize lists
                    m.actor_id = new List<string>();
                    m.actor_img = new List<string>();
                    m.character = new List<string>();
                    m.actors = new List<string>();
                    m.genres = new List<string>();
                    m.numbering = new List<string>();


                    //gets the full movie info
                    var parser = ((IEnumerable<dynamic>)returned.results);
                    var pars = parser.First();
                    string movId = Convert.ToString(pars.id);
                    
                    //prepare strings for full movie info and actors 
                    prepare = String.Format("https://api.themoviedb.org/3/movie/{0}?language=en-US&api_key={1}", movId, api_key);
                    string prepare0 = String.Format("https://api.themoviedb.org/3/movie/{0}/credits?api_key={1}", movId, api_key);


                    //requests for various movie data
                    dynamic returned0 = restRequest(prepare);
                    dynamic returned1 = restRequest(prepare0);

                    m = movDataIn(returned0, returned1, m);
                }
            }
            catch (RuntimeBinderException z) { }
            //Console.WriteLine(Convert.ToString(returned.overview));
            return m;
        }
        private dynamic restRequest(string url)
        {
            dynamic returned;
            Thread.Sleep(100);
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            returned = Json.Decode(response.Content);
            return returned;
        }

        private movObj movDataIn(dynamic b, dynamic c, movObj m)
        {
            //general movie data
            m.title = b.title;
            m.description = b.overview;
            m.imgPath = poster_first + b.poster_path;
            m.numbering.Add(Convert.ToString(b.runtime));
            m.numbering.Add(Convert.ToString(b.vote_average));
            m.numbering.Add(Convert.ToString(b.Budget));
            m.numbering.Add(Convert.ToString(b.revenue));


            //genres
            var parser = ((IEnumerable<dynamic>)b.genres);
            foreach (var par in parser)
            {
                String genreTemp = par.name;
                m.genres.Add(Convert.ToString(genreTemp));
            }

            //credits
            parser = ((IEnumerable<dynamic>)c.cast);
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    string imgpath = String.Format("https://image.tmdb.org/t/p/w264_and_h264_bestv2{0}", parser.ElementAt(i).profile_path);
                    m.actor_id.Add(Convert.ToString(parser.ElementAt(i).id));
                    m.actors.Add(parser.ElementAt(i).name);
                    m.character.Add(parser.ElementAt(i).character);
                    m.actor_img.Add(imgpath);
                }
                catch (ArgumentNullException e) { }
            }

            return m;
        }

    }

    public class movObj
    {

        public string description { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string path { get; set; }
        public string imgPath { get; set; }

        //runtime
        //vote_average
        //budget
        //revenue
        public List<string> numbering { get; set; }
        public List<string> genres { get; set; }
        public List<string> actors { get; set; }
        public List<string> actor_img { get; set; }
        public List<string> actor_id { get; set; }
        public List<string> character { get; set; }

        public delegate string getvalue(string path);
        public void search()
        {
            Info searching = new Info();
            searching.movInfo(title, this);
        }
        public movObj(string dir, string nam)
        {
            path = dir;
            if (nam.Contains("("))
            {
                string movTitle = nam.Split('(')[0];
                movTitle = movTitle.Substring(0, movTitle.Length - 1);
                title = movTitle;
                year = nam.Split('(')[1].Substring(0, 4);
            }
            else
            {
                year = "9999";
                title = nam;
            }
        }
    }
}