using SDM.Compulsory.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.DomainService
{
    public interface IReviewRepository
    {
        int ReviewersNumberOfReviews(Review id); //N = Review  1
        int ReviewersAverageReviews(Review id); //N = Review  2
        int NumberOfReviewPrMovie(Review id); // N = Review | G = Review.Grade  3
        int MoviesNumberOfReview(Review id); //N = Number Of reviews pr movie  4
        double AverageRatingPerMovie(Review id);//  5
        int NumberOfMoviewWithGrade(Review id); //  6
        List<Review> GetBestGradeMovieID(Review id);//  7
        List<Review> HighestNumberOfReviews(Review id);//  8
        List<Review> TopSomethingOfMovies();//  9
        List<Review> SortedMoviesReviewedByReviewer();//  10
        List<Review> SortedReviewersOfMovie();
    }
}
