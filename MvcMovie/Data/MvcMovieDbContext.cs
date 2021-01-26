using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data{
    public class MvcMovieDbContext: DbContext 
    {
        public MvcMovieDbContext(DbContextOptions <MvcMovieDbContext> options)
        : base(options) 
        {

        } 
        public DbSet<Movie> Movie {get; set; } 
         }
}