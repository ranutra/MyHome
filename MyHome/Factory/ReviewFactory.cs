using MyHome.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHome.Factory
{
    public class ReviewFactory
    {
        public static Review createReview(int id, DateTime createdAt, int rating, string reviewText, int projectId, int reviewerId)
        {
            Review review = new Review
            {
                Id = id,
                CreatedAt = createdAt,
                Rating = rating,
                ReviewText = reviewText,
                ProjectId = projectId,
                ReviewerId = reviewerId
            };
            return review;
        }
    }
}