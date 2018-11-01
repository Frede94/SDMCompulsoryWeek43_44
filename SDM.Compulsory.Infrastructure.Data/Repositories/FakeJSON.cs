using SDM.Compulsory.Core.DomainService;
using SDM.Compulsory.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Infrastructure.Data
{
    public class FakeJSON : IReviewRepository
    {
        //{ Reviewer:571, Movie:1057933, Grade:3, Date:'2005-12-23'}, 
        //{ Reviewer:571, Movie:673306, Grade:3, Date:'2005-07-05'}, 
        //{ Reviewer:571, Movie:260373, Grade:3, Date:'2005-07-06'}, 
        //{ Reviewer:571, Movie:2566738, Grade:4, Date:'2005-07-06'}, 
        //{ Reviewer:605, Movie:2052325, Grade:4, Date:'2003-11-18'}, 
        //{ Reviewer:605, Movie:724071, Grade:4, Date:'2001-07-17'}, 
        //{ Reviewer:605, Movie:1190655, Grade:4, Date:'2005-07-07'}, 
        //{ Reviewer:607, Movie:1721475, Grade:3, Date:'2005-07-07'}, 
        //{ Reviewer:607, Movie:1919197, Grade:3, Date:'2005-07-07'}, 
        //{ Reviewer:607, Movie:595907, Grade:4, Date:'2005-07-08'}, 
        //{ Reviewer:607, Movie:884152, Grade:4, Date:'2005-07-08'}, 

        //public static int reviewerId;
        //public static int movieId;
        public List<Review> Reviews { get; }

        public FakeJSON()
        {
            Reviews = new List<Review>
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
        }
    }
}
