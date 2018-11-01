using SDM.Compulsory.Core.ApplicationService.IServices;
using SDM.Compulsory.Core.DomainService;
using SDM.Compulsory.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //5
        public double AverageRatingPerMovie(Review id)
        {
            throw new NotImplementedException();
        }
        //7
        public List<Review> GetBestGradeMovieID(Review id)
        {
            throw new NotImplementedException();
        }
        //8
        public List<Review> HighestNumberOfReviews(Review id)
        {
            throw new NotImplementedException();
        }
        //4
        public int MoviesNumberOfReview(Review id)
        {
            throw new NotImplementedException();
        }
        //6
        public int NumberOfMoviewWithGrade(Review id)
        {
            throw new NotImplementedException();
        }
        //3
        public int NumberOfReviewPrMovie(Review id)
        {
            throw new NotImplementedException();
        }
        //2
        public int ReviewersAverageReviews(Review id)
        {
            throw new NotImplementedException();
        }
        //1
        public List<Review> ReviewersNumberOfReviews(int reviewerID)
        {
            var list = repository.Reviews;
            var reviewer = list.Where(r => r.ReviewerID.Equals(reviewerID));
            reviewer.Count();
            return reviewer.ToList();
        }
        //10
        public List<Review> SortedMoviesReviewedByReviewer()
        {
            throw new NotImplementedException();
        }
        //11
        public List<Review> SortedReviewersOfMovie()
        {
            throw new NotImplementedException();
        }
        //9
        public List<Review> TopSomethingOfMovies()
        {
            throw new NotImplementedException();
        }
    }
}
