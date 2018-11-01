using SDM.Compulsory.Core.Entity;
using SDM.Compulsory.Core.Entity.Repositories;
using SDM.Compulsory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SDM.Compulsory.Test
{
    public class FakeJSONTest
    {
        [Fact]
        public void ReadAllReviewsFromFakeJSON()
        {
            List<Review> Expected = new List<Review>
            {
                new Review(571,1057933,3,new DateTime(2005,12,23)),
                new Review(571,673306,3,new DateTime(2005,07,05)),
                new Review(571,260373,3,new DateTime(2005,07,06)),
                new Review(571,2566738,4,new DateTime(2005,07,06)),
                new Review(605,2052325,4,new DateTime(2003,11,18)),
                new Review(605,724071,4,new DateTime(2001,07,17)),
                new Review(605,1190655,4,new DateTime(2005,07,07)),
                new Review(607,1721475,3,new DateTime(2005,07,07)),
                new Review(607,1919197,3,new DateTime(2005,07,07)),
                new Review(607,595907,4,new DateTime(2005,07,08)),
                new Review(607,884152,4,new DateTime(2005,07,08))
            };

            List<Review> Actual = new FakeJSON().Reviews;

            Assert.Equal(Expected, Actual);
        }

    }
}
