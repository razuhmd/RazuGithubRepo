using RazuDevOps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazuDevOps.Repository
{
    public class FakeRepository
    {
        public List<Movie> _movies = new List<Movie>();

        Movie m1 = new Movie(1, "Movie1", 2000, 120, 1);
        Movie m2 = new Movie(2, "Movie2", 2000, 120, 1);
        Movie m3 = new Movie(3, "Movie3", 2000, 120, 2);
        Movie m4 = new Movie(4, "Movie4", 2000, 120, 2);

       
    }
}
