using SDM.Compulsory.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.DomainService
{
    public interface IReviewRepository
    {
        List<Review> Reviews { get; }
    }
}
