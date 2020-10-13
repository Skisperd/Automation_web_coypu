using NUnit.Framework;
using AutomationCoypu.Pages;
using AutomationCoypu.Common;
using System.Threading;
using AutomationCoypu.Models;
using System;

namespace AutomationCoypu.Tests
{
    public class SaveMovieTest : BaseTest
    {
        private LoginPage _login;

        private MoviePage _movie;

        [SetUp]
        public void Before()
        {
            _login = new LoginPage(Browser);
            _movie = new MoviePage(Browser);
            _login.With("tiago.dias@sidia.com", "123456");
        }
        [Test]
        
        public void ShouldSaveMovie()
        {
            var movieData = new MovieModel()
            {
                Title = "Resident Evil",
                Status = "Disponível",
                Year = "2000",
                ReleaseDate = "01/05/2002",
                Cast = {"Tiago", "Felipe", "Dias", "Oliveira"},
                Plot = "A missão é fazer isso funfar",
                Cover = CoverPath() + "resident_evil.jpg"
            };          

            _movie.Add();
            _movie.Save(movieData);
            Thread.Sleep(15000);
        }

    }

}