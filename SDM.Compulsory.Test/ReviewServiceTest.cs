using SDM.Compulsory.Core.ApplicationService.IServices;
using SDM.Compulsory.Core.ApplicationService.Services;
using SDM.Compulsory.Core.Entity;
using SDM.Compulsory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SDM.Compulsory.Test
{
    public class ReviewServiceTest
    {
        [Fact]//1
        public void ReviewersNumberOfReviewsTest()
        {
            int reviewerID = 571;
            IReviewService service = new ReviewService(new FakeJSON());
            List<Review> result = service.ReviewersNumberOfReviews(reviewerID);

            Assert.True(result.Count == 4);
        }

        [Fact]//2
        public void ReviewersAverageRatingTest()
        {
            int reviewerID = 571;
            double average = 3.25;
            IReviewService service = new ReviewService(new FakeJSON());
            double result = service.ReviewersAverageRatings(reviewerID, average);

            Assert.Equal(average, result);
        }

        [Fact]//3
        public void NumberOfGradesMovieTest()
        {
            var reviewerID = 571;
            var grade = 3;
            var nrOfReviews = 3;
            IReviewService service = new ReviewService(new FakeJSON());
            int result = service.NumberOfXGradesMovie(reviewerID, grade);

            Assert.Equal(nrOfReviews, result);
        }

        [Fact]//4
        public void MoviesNumberOfReviewersTest()
        {
            int movieID = 2052325;
            int numberOfReviews = 2;
            IReviewService service = new ReviewService(new FakeJSON());
            int result = service.MoviesNumberOfReviewers(movieID, numberOfReviews);

            Assert.Equal(numberOfReviews, result);
        }

        [Fact]//5
        public void AverageRatingPerMovieTest()
        {
            double average = 3.5;
            int movieID = 2052325;
            IReviewService service = new ReviewService(new FakeJSON());
            double result = service.AverageRatingPerMovie(movieID, average);

            Assert.Equal(average, result);
        }

        [Fact]//6
        public void NumberOfMoviewWithGradeTest()
        {
            var movieID = 2052325;
            var grades = 3;
            var nrOfMoviews = 1;
            IReviewService service = new ReviewService(new FakeJSON());
            double result = service.NumberOfMoviewWithGrade(movieID, grades);

            Assert.Equal(nrOfMoviews, result);
        }
    }
}
