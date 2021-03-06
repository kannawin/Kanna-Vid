﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using System.Net;
using RestSharp;
using Movie_Info;
using System.Web.Helpers;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;


namespace Kanna_Movies
{
    public partial class Kanna_Vod : Form
    {
        //IP to the raspberry pi being used.
        private string rpi = "http://10.248.58.161/";
        
        
        private List<movObj> movies = new List<movObj>();
        private bool returnToState = false;
        private bool sortState = false;
        private bool fullScreenState = true;


        public Kanna_Vod()
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            InitializeComponent();
            populate();
            
            //play.Enabled = false;
            //stop.Enabled = false;
            
            
            //gives it a nice black theme
            stop.BackColor = Color.Black; 
            play.BackColor = Color.Black;
            volup.BackColor = Color.Black;
            voldown.BackColor = Color.Black;
            skip30back.BackColor = Color.Black;
            skip30for.BackColor = Color.Black;
            skip10back.BackColor = Color.Black;
            skip10mfor.BackColor = Color.Black;
            fastfow.BackColor = Color.Black;
            rewind.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            watch.BackColor = Color.Black;
            fullScreen.BackColor = Color.Black;
            tvon.BackColor = Color.Black;
            tvoff.BackColor = Color.Black;
            
            //try to get actual movies from the server else put some test data in
            try
            {
                movList.SetSelected(0, true);
            }
            catch (ArgumentOutOfRangeException e) {
                movies.Add(new movObj(null, "The Godfather (1972)"));
                movies.Add(new movObj(null, "Casablanca (1942)"));
                movies.Add(new movObj(null, "Shawshank Redemption (1994)"));
                movies.Add(new movObj(null, "Doctor Strange (2016)"));
                movies.Add(new movObj(null, "Cloud Atlas (2012)"));
                foreach(movObj mov in movies){
                    movList.Items.Add(mov.title + "   (" + mov.year + ")");
                }
                movList.SetSelected(0, true);
            }
        }
        
        //plays the movie 
        [STAThread]
        private void start(object sender, EventArgs e)
        {
            string url = "";
            
            //parse data from selected movie properly, & symbols are not liked in GET methods
            if(movies.ElementAt(movList.SelectedIndex).path.Contains('&'))
                url = String.Format("{1}/index2.php?path={0}",movies.ElementAt(movList.SelectedIndex).path.Replace("&","{"), rpi);
            else
                url = String.Format("{1}/index2.php?path={0}",movies.ElementAt(movList.SelectedIndex).path, rpi);

            HttpWebResponse myResponse = null;
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            
            //once the movie is selected and the button is clicked it will attempt to play the movie
            System.IO.Stream myStream = null;
            StreamReader myStreamReader = null;
            myRequest.Method = "GET";
            myRequest.Proxy = null;
            myRequest.Timeout = 100;
            myRequest.KeepAlive = false;
            try
            {
                myResponse = (HttpWebResponse)myRequest.GetResponse();
            }
            catch (Exception ex)
            {
                //intentionally left blank, used to initialize the movie
            }
            
            if (myResponse != null)
            {
                if (myResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    myStream = myResponse.GetResponseStream();
                    myStreamReader = new StreamReader(myStream);
                }
            }

            myResponse = null;
            myRequest = (HttpWebRequest)WebRequest.Create(new Uri(rpi + "movie.php"));
            try
            {
                myResponse = (HttpWebResponse)myRequest.GetResponse();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error : " + ex.Message);
            }
            //watch.Enabled = false;
            play.Enabled = true;
            stop.Enabled = true;
        }
        
        //sends a pause command for the movie
        private void pause(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            if (returnToState)
            {
                action("p");
                action("p");
                returnToState = false;
            }
            else action("p");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //try/catch 404 server 
        private void movList_changeIndex(object sender, EventArgs e)
        {
            //populates the relevant movie info within the window 
            try
            {
                //label3.Text = movies.ElementAt(movList.SelectedIndex).path;
                if (movies.ElementAt(movList.SelectedIndex).imgPath == null)
                {
                    movies.ElementAt(movList.SelectedIndex).search();
                }
                if (movies.ElementAt(movList.SelectedIndex).imgPath != "https://Image.tmdb.org/t/p/w300_and_h450_bestv2" &&
                    movies.ElementAt(movList.SelectedIndex).imgPath != null)
                {
                    poster.Load(movies.ElementAt(movList.SelectedIndex).imgPath);
                    title.Text = movies.ElementAt(movList.SelectedIndex).title;
                    label1.Text = "(" + movies.ElementAt(movList.SelectedIndex).year + ")";
                    //label1.Text = movies.ElementAt(movList.SelectedIndex).actor_img.ElementAt(0);


                    description.Text = movies.ElementAt(movList.SelectedIndex).description;
                    rating.Text = "Run time: " + movies.ElementAt(movList.SelectedIndex).numbering.ElementAt(0) + " minutes";
                    len.Text = "IMDB Rating: " + movies.ElementAt(movList.SelectedIndex).numbering.ElementAt(1);
                    
                    //load actors pics
                    loadPics();


                }
            }
            catch (ArgumentOutOfRangeException f)
            {

            }
        }
        
        //stops the movie
        private void stop_movie(object sender, EventArgs e)
        {
            action("q");
            watch.Enabled = true;
            play.Enabled = false;
            stop.Enabled = false;
        }
        
        //default action method, sends qhatever command to the raspberry pi to control the movie or tv
        private void action(string command)
        {
            string url = String.Format("{1}index.php?comm={0}", command, rpi);
            HttpWebResponse myResponse = null;
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            try
            {
                myResponse = (HttpWebResponse)myRequest.GetResponse();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error : " + ex.Message);
            }
        }
        
        //populates the list of movies from the json string generated on the raspberry pi's end
        private void populate()
        {
            var client = new RestClient(rpi + "list.php");
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            string output = response.Content;

            dynamic returned;
            returned = Json.Decode(output);
            try
            {
                int j = returned.count;

                for (int i = 4; i < j; i++)
                {
                    movies.Add(new movObj(returned.results[i][1], returned.results[i][0]));
                }

                sort(true);

                for (int i = 0; i < movies.Count; i++)
                {
                    movList.Items.Add(movies.ElementAt(i).title + "  (" + movies.ElementAt(i).year + ")");
                }
            }
            catch (RuntimeBinderException e)
            {
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            action("9");
        }

        private void vol_down(object sender, EventArgs e)
        {
            action("-");
        }

        private void thirty_back(object sender, EventArgs e)
        {
            action("<");
            play.Text = "Play";
            returnToState = true;
        }

        private void thirty_forward(object sender, EventArgs e)
        {
            action(">");
            play.Text = "Play";
            returnToState = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            action("^[[D");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            action("^[[B");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            action("^[[C");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            action("^[[A");
        }
        
        
        //selects a random movie
        private void random(object sender, EventArgs e)
        {
            Random randIndex = new Random(System.DateTime.Now.Millisecond);
            int rand = randIndex.Next(movies.Count);
            try
            {
                movList.SelectedIndex = rand;
            }
            catch (ArgumentOutOfRangeException f)
            {
            }

        }
        
        //sorts based on type, either alphabetically or by year
        private void sort(bool type)
        {
            if (type && sortState)
            {
                movies.Sort(delegate(movObj a, movObj b){
                    return String.Compare(b.title, a.title);
                });
                sortState = false;
            }
            else if (type)
            {
                movies.Sort(delegate(movObj a, movObj b)
                {
                    return String.Compare(a.title, b.title);
                });
                sortState = true;
            }
            else if(!type && !sortState){
                movies.Sort(delegate(movObj a, movObj b){
                    return String.Compare(b.year,a.year);
                });
                sortState = true;
            }
            else{
                movies.Sort(delegate(movObj a, movObj b)
                {
                    return String.Compare(a.year, b.year);
                });
                sortState = false;
            }
        }
        
        //creates the movie string once movie info is found in the form of <movie title> (year)
        private void name_format(object sender, EventArgs e)
        {
            sort(true);
            movList.Items.Clear();
            for (int i = 0; i < movies.Count; i++)
            {
                movList.Items.Add(movies.ElementAt(i).title + "  (" + movies.ElementAt(i).year + ")");
            }
        }
        
        //does the same as above
        private void name_format2(object sender, EventArgs e)
        {
            sort(false);
            movList.Items.Clear();
            for (int i = 0; i < movies.Count; i++)
            {
                movList.Items.Add(movies.ElementAt(i).title + "  (" + movies.ElementAt(i).year + ")");
            }
        }
        
        //sends the program to full screen
        private void fullScreen_Click_1(object sender, EventArgs e)
        {
            if (fullScreenState)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                //this.Bounds = Screen.PrimaryScreen.WorkingArea;
                fullScreen.Text = "Enter Full Screen";
                fullScreenState = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                this.TopMost = true;
                fullScreen.Text = "Exit Full Screen";
                fullScreenState = true;
            }
        }
        
        //turns the tv on
        private void tvon_Click(object sender, EventArgs e)
        {
            action("tvon");
        }
        //if the tv allows, will turn it off. disabled for current testing
        private void tvoff_Click(object sender, EventArgs e)
        {
            action("tvoff");
        }
        
        //once a movie is selected it will load all relevant pictures. Movie poster, actors, names and their character
        private void loadPics()
        {
            pictureBox4.Image = null;
            pictureBox3.Image = null;
            pictureBox2.Image = null;
            pictureBox1.Image = null;
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";

            if (movies.ElementAt(movList.SelectedIndex).actor_img.Count() >= 4)
            {
                pictureBox4.Load(movies.ElementAt(movList.SelectedIndex).actor_img.ElementAt(3));
                label10.Text = movies.ElementAt(movList.SelectedIndex).actors.ElementAt(3);
                label11.Text = movies.ElementAt(movList.SelectedIndex).character.ElementAt(3);
            }
            if (movies.ElementAt(movList.SelectedIndex).actor_img.Count() >= 3)
            {
                pictureBox3.Load(movies.ElementAt(movList.SelectedIndex).actor_img.ElementAt(2));
                label8.Text = movies.ElementAt(movList.SelectedIndex).actors.ElementAt(2);
                label9.Text = movies.ElementAt(movList.SelectedIndex).character.ElementAt(2);
            }
            if (movies.ElementAt(movList.SelectedIndex).actor_img.Count() >= 2)
            {
                pictureBox2.Load(movies.ElementAt(movList.SelectedIndex).actor_img.ElementAt(1));
                label6.Text = movies.ElementAt(movList.SelectedIndex).actors.ElementAt(1);
                label7.Text = movies.ElementAt(movList.SelectedIndex).character.ElementAt(1);
            }
            if (movies.ElementAt(movList.SelectedIndex).actor_img.Count() >= 1)
            {
                pictureBox1.Load(movies.ElementAt(movList.SelectedIndex).actor_img.ElementAt(0));
                label4.Text = movies.ElementAt(movList.SelectedIndex).actors.ElementAt(0);
                label5.Text = movies.ElementAt(movList.SelectedIndex).character.ElementAt(0);
            }

        }
    }
}
