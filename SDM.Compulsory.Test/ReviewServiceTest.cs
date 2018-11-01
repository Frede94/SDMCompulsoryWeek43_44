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
        [Fact]
        public void ReviewersNumberOfReviewsTest()
        {
            int reviewerID = 571;            
            IReviewService service = new ReviewService(new FakeJSON());
            List<Review> result = service.ReviewersNumberOfReviews(reviewerID);

            Assert.True(result.Count == 4);            
        }

        [Fact]
        public void ReviewersAverageRatingTest()
        {            
            int reviewerID = 571;
            double average = 3.25;
            IReviewService service = new ReviewService(new FakeJSON());
            double result = service.ReviewersAverageRatings(reviewerID, average);

            Assert.Equal(average, result);
        }

        [Fact]
        public void NumberOfReviewPrMovie()
        {

        }
    }
}
