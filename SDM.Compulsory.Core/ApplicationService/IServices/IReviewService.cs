using SDM.Compulsory.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.ApplicationService.IServices
{
    public interface IReviewService
    {
        //1. On input N, what are the number of reviews from reviewer N?
        //2. On input N, what is the average rate that reviewer N had given?
        //3. On input N and G, how many times has reviewer N given a movie grade G?
        //4. On input N, how many have reviewed movie N?
        //5. On input N, what is the average rate the movie N had received?
        //6. On input N and G, how many times had movie N received grade G?
        //7. What is the id(s) of the movie(s) with the highest number of top rates(5)?
        //8. What reviewer(s) had done most reviews?
        //9. On input N, what is top N of movies? The score of a movie is its average rate.
        //10. On input N, what are the movies that reviewer N has reviewed? The list should
        //be sorted decreasing by rate first, and date secondly.
        //11. On input N, what are the reviewers that have reviewed movie N? The list
        //should be sorted decreasing by rate first, and date secondly.

        Review ReviewersNumberOfReviews(Review N); //N = Review  1
        Review ReviewersAverageReviews(Review N); //N = Review  2
        int NumberOfReviewPrMovie(Review N, Review G); // N = Review | G = Review.Grade  3
        Review MoviesNumberOfReview(Review N); //N = Number Of reviews pr movie  4
        Review AverageRatingPerMovie(Review N);//  5
        Review NumberOfMoviewWithGrade(Review N, Review G); //  6
        Review GetBestGradeMovieID(Review id);//  7
        Review HighestNumberOfReviews(Review id);//  8
        Review What(Review N);//  9
        List<Review> SortedMoviesReviewedByReviewer();//  10
        List<Review> SortedReviewersOfMovie();// 11
    }
}
