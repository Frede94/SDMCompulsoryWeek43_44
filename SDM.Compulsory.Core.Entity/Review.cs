using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.Entity
{
    public class Review
    {
        public Review(int reviewID, int movieID, int grade, DateTime date)
        {
            if (grade < 1 || grade > 5)
            {
                throw new ArgumentException("Invalid Grade");
            }
            ReviewerID = reviewID;
            MovieID = movieID;
            Grade = grade;
            Date = date;
        }

        //Reviewer:571, Movie:15731, Grade:2, Date:'2004-06-14
        public int ReviewerID { get; }
        public int MovieID { get; }
        public int Grade { get; }
        public DateTime Date { get; }
    }
}
