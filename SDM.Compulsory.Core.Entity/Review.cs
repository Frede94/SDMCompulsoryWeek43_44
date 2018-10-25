using System;
using System.Collections.Generic;
using System.Text;

namespace SDM.Compulsory.Core.Entity
{
    public class Review
    {
        //Reviewer:571, Movie:15731, Grade:2, Date:'2004-06-14
        public int ReviewerID { get; set; }
        public int MovieID { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
