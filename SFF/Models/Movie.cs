using System;
using System.Collections.Generic;

namespace SFF.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        //public decimal Duration { get; set; }

        public int AmountOfMovies { get; set; }

        public int MaxAmount { get; set; }

        public bool isLent { get; set; } = false;

        public int MovieStudioId { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public void AddReview(Review review, MovieStudio movieStudio)
        {
            review.MovieStudio = movieStudio;
            Reviews.Add(review);
        }

    }
}
