﻿using Movieve.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Movieve.Services
{
    public class SendRequest
    {
        public dynamic Data { get; set; }
        HttpClient http = new HttpClient();
        public string GetPoster(string source)
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = http.GetAsync($@"http://www.omdbapi.com/?apikey=e4d8a8d9&s={source}&plot=full").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject(str);
                string poster = Data.Search[0].Poster;
                return poster;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public string GetTitle(string source)
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = http.GetAsync($@"http://www.omdbapi.com/?apikey=e4d8a8d9&s={source}&plot=full").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject(str);
                string title = Data.Search[0].Title;
                return title;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public string GetGenre(string source)
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = http.GetAsync($@"http://www.omdbapi.com/?apikey=e4d8a8d9&t={source}&plot=full").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject(str);
                string genre = Data.Genre;
                return genre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public string GetYear(string source)
        {
            try
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = http.GetAsync($@"http://www.omdbapi.com/?apikey=e4d8a8d9&s={source}&plot=full").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject(str);
                string title = Data.Search[0].Year;
                return title;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
