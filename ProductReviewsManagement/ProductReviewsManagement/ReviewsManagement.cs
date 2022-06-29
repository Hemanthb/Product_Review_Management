using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewsManagement
{
    public class ReviewsManagement
    {
        //UC-2 FETCHING TOP-3 HIGH RATED REVIEWS
        public void GetHighReviews(List<ProductReview> productReviews)
        {
            var highRated = from review in productReviews orderby review.Rating descending select productReviews.Take(3).FirstOrDefault();
            foreach(var review in highRated)
            {
                Console.WriteLine(review.ProductId+" | "+review.Rating);
            }
        }
        //UC-3 FETCHING RECORDS WITH RATING > 3 AND PRODUCT IS 1 OR 4 OR 9
        public void RatingsGreaterThanThree(List<ProductReview> productReviews)
        {
            var result = (from product in productReviews
                          where product.Rating > 3 &&
                          (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9)
                          select product);
            Console.WriteLine("Records having ratings greater than 3 and who's product ID is 1 or 4 or 9 is ->");
            foreach (var item in result)
            {
                Console.WriteLine("Product ID: " + item.ProductId + "\tUser ID: " + item.UserId + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);

            }
        }
    }
}
