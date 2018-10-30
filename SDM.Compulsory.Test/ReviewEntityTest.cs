using SDM.Compulsory.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SDM.Compulsory.Test
{
    public class ReviewEntityTest
    {
        [Theory]
        [InlineData(1,2,3,2018,1,1)]
        [InlineData(1, 2, 1, 2018, 1, 1)]
        [InlineData(1, 2, 5, 2018, 1, 1)]
        public void CreateValidValueEntity(int reviewID,int movieID, int grade, int year, int month, int day)
        {
            Review review1 = new Review
            (
                reviewID,
                movieID,
                grade,
                new DateTime(year,month,day) 
            );
            Assert.Equal(reviewID, review1.ReviewerID);
            Assert.Equal(movieID, review1.MovieID);
            Assert.Equal(grade, review1.Grade);
            Assert.Equal(new DateTime(year, month, day), review1.Date);
        }
        [Theory]
        [InlineData(1, 2, 0, 2018, 1, 1)]
        [InlineData(1, 2, 6, 2018, 1, 1)]
        public void CreateReviewInvalidGradeExpectArgumentException(int reviewID, int movieID, int grade, int year, int month, int day)
        {            
            Review review1 = null;
            var ex = Assert.Throws<ArgumentException>(()=> review1 = new Review
            (
                reviewID,
                movieID,
                grade,
                new DateTime(year, month, day)
            ));
            Assert.Equal("Invalid Grade",ex.Message);
            Assert.Null(review1);
        }        
    }
}
