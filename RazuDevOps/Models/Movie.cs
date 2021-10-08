using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazuDevOps.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int RunningTimeInMins { get; set; }
        public int StudiosId { get; set; }

        public Movie(int id, string title, int year, int runningTimeInMins, int studiosId)
        {
            //
            Id = id;
            Title = title;
            Year = year;
            RunningTimeInMins = runningTimeInMins;
            StudiosId = studiosId;
        }
    }
}
