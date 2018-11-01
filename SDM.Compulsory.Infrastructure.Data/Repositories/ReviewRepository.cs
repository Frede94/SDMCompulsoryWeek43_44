
﻿using Newtonsoft.Json;
using SDM.Compulsory.Core.DomainService;
using SDM.Compulsory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SDM.Compulsory.Core.Entity.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public const string filename = "ratings.json";
        public List<Review> Reviews { get; private set; }
        public ReviewRepository()
        {
            Reviews = ReadAllMovies();
        }
        private List<Review> ReadAllMovies()
        {        
            List<Review> reviews = new List<Review>();
            Console.Write("Converting JSON file to objects");
            Stopwatch sw = Stopwatch.StartNew();
            using (StreamReader streamReader = new StreamReader(filename))                        
            using (JsonTextReader reader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                try
                {
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            Review rv = ReadOneReview(reader);
                            reviews.Add(rv);
                        }
                    }
                }
                catch (JsonReaderException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sw.Stop();
            Console.WriteLine("Done. Time = {0:f4} sec.", sw.ElapsedMilliseconds / 1000d);

            Dictionary<int, List<Review>> Reviewers = new Dictionary<int, List<Review>>();
            Dictionary<int, List<Review>> Movies = new Dictionary<int, List<Review>>();

            Console.Write("Indexing MovieRatings... ");
            sw.Restart();
            foreach (Review r in reviews)
            {
                if (!Reviewers.ContainsKey(r.ReviewerID))
                    Reviewers[r.ReviewerID] = new List<Review>();
                Reviewers[r.ReviewerID].Add(r);

                if (!Movies.ContainsKey(r.MovieID))
                    Movies[r.MovieID] = new List<Review>();
                Movies[r.MovieID].Add(r);
            }

            Console.Write("Indexing MovieRatings... ");
            sw.Restart();
            foreach (Review r in reviews)
            {
                if (!Reviewers.ContainsKey(r.ReviewerID))
                    Reviewers[r.ReviewerID] = new List<Review>();
                Reviewers[r.ReviewerID].Add(r);

                if (!Movies.ContainsKey(r.MovieID))
                    Movies[r.MovieID] = new List<Review>();
                Movies[r.MovieID].Add(r);
            }
            sw.Stop();
            Console.WriteLine("Done. Time = {0:f4} sec.", sw.ElapsedMilliseconds / 1000d);

            foreach (KeyValuePair<int, List<Review>> kv in Reviewers)
            {
                Console.WriteLine("Reviewer: {0,4} has reviewed {1,6} movies.", kv.Key, kv.Value.Count);
            }
            return reviews;

        }

        private Review ReadOneReview(JsonTextReader reader)
        {
            Review r = new Review();
            for (int i = 0; i < 4; i++)
            {
                reader.Read();
                switch (reader.Value)
                {
                    case "Reviewer": r.ReviewerID = (int)reader.ReadAsInt32(); break;
                    case "Movie": r.MovieID = (int)reader.ReadAsInt32(); break;
                    case "Grade": r.Grade = (int)reader.ReadAsInt32(); break;
                    case "Date": r.Date = (DateTime)reader.ReadAsDateTime(); break;
                    default: throw new InvalidDataException("no such token: " + reader.Value);
                }
            }
            return r;

        }
    }
}
