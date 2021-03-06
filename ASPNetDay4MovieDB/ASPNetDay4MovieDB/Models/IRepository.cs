﻿using System;
using System.Collections.Generic;
namespace ASPNetDay4MovieDB.Models
{
    public interface IRepository
    {
        void CreateMovie(Movie movieToCreate);
        void DeleteMovie(int id);
        Movie FindMovie(int id);
        IList<Movie> ListMovies();
        void UpdateMovie(Movie movieToUpdate);
    }
}
