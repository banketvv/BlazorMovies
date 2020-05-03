﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }

        private List<Movie> movies;
        protected override void OnInitialized()
        {
            base.OnInitialized();

            movies = new List<Movie>()
            {
                new Movie() { Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2) },
                new Movie() { Title = "Avengers", ReleaseDate = new DateTime(2016, 11, 23) },
            };
        }

        private int currentCount = 0;
        private void IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
