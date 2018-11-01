using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.Entity
{
    public class Review
    {
        public Review()
        {
        }

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
        public int ReviewerID { get; set; }
        public int MovieID { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return string.Format("Reviewer: {0}\nMovie: {1}\nGrade: {2}\nDate: {3}\n", ReviewerID, MovieID, Grade, Date);
        }
    }
}
