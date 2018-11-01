using SDM.Compulsory.Core.DomainService;
using SDM.Compulsory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.Entity.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public FakeJSON fakeJSON;

        public IEnumerable<Review> ReadAllMovies()
        {
            return fakeJSON.Reviews;
        }
    }
}
