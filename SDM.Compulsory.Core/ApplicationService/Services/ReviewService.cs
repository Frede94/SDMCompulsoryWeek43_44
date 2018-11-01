using SDM.Compulsory.Core.ApplicationService.IServices;
using SDM.Compulsory.Core.DomainService;
using SDM.Compulsory.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.ApplicationService.Services
{
    public class ReviewService : IReviewService
    {
        IReviewRepository repository;

        public ReviewService(IReviewRepository reRepo)
        {
            repository = reRepo;
        }

        public double AverageRatingPerMovie(Review id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetBestGradeMovieID(Review id)
        {
            throw new NotImplementedException();
        }

        public List<Review> HighestNumberOfReviews(Review id)
        {
            throw new NotImplementedException();
        }

        public int MoviesNumberOfReview(Review id)
        {
            throw new NotImplementedException();
        }

        public int NumberOfMoviewWithGrade(Review id)
        {
            throw new NotImplementedException();
        }

        public int NumberOfReviewPrMovie(Review id)
        {
            throw new NotImplementedException();
        }

        public int ReviewersAverageReviews(Review id)
        {
            throw new NotImplementedException();
        }

        public int ReviewersNumberOfReviews(Review id)
        {
            throw new NotImplementedException();
        }

        public List<Review> SortedMoviesReviewedByReviewer()
        {
            throw new NotImplementedException();
        }

        public List<Review> SortedReviewersOfMovie()
        {
            throw new NotImplementedException();
        }

        public List<Review> TopSomethingOfMovies()
        {
            throw new NotImplementedException();
        }
    }
}
