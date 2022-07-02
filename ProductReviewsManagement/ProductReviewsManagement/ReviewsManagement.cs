using System;
using System.Collections.Generic;
using System.Data;
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
        //UC4 COUNT OF REVIEWS FOR EACH PRODUCT ID
        public void countOFReviewForProductID(List<ProductReview> productReviews)
        {
            var result = (productReviews.GroupBy(product => product.ProductId).Select(p => new { ProductID = p.Key, Count = p.Count() }));
            Console.WriteLine("Product ID\t|\tCount");
            foreach (var item in result)
            {
                Console.WriteLine("\t" + item.ProductID + "\t|\t" + item.Count);
            }
        }
        //UC5 RETRIEVE PRODUCT ID AND REVIEWS
        public void ProductIDAndReview(List<ProductReview> productReviews)
        {
            var result = (from product in productReviews
                          select new { ProductID = product.ProductId, Review = product.Review });
            Console.WriteLine("Product ID\t|\tReview");
            foreach (var item in result)
            {
                Console.WriteLine("\t" + item.ProductID + "\t|\t" + item.Review);
            }
        }
        //UC6 DISPLAY RECORDS SKIPPING TOP 5
        public void SkipTop5Records(List<ProductReview> productReviews)
        {
            var result = (from product in productReviews
                          select product).Skip(5);
            Console.WriteLine("Records after skiping top 5");
            Console.WriteLine("- - - - - - - - - - - - - -");
            foreach (var item in result)
            {
                Console.WriteLine("Product ID: " + item.ProductId + "\tUser ID: " + item.UserId + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);
            }
        }
        //UC7 Retrieve only Product ID and review from records using LINQ select
        public void ProductIDAndReviewUsingSelectLINQ(List<ProductReview> productReviews)
        {
            var result = productReviews.Select(reviews => new { ProductID = reviews.ProductId, Review = reviews.Review });
            Console.WriteLine("Product ID\t|\tReview");
            foreach (var item in result)
            {
                Console.WriteLine("\t" + item.ProductID + "\t|\t" + item.Review);
            }
        }
        //UC 8 CREATE DATA TABLE AND ADD VALUES TO IT
        public DataTable createDatatable(List<ProductReview> productReviews)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID", typeof(Int32));
            table.Columns.Add("UserID", typeof(Int32));
            table.Columns.Add("Rating", typeof(Int32));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("isLike", typeof(bool));
            foreach (var item in productReviews)
            {
                table.Rows.Add(item.ProductId, item.UserId, item.Rating, item.Review, item.isLike);
            }
            Console.WriteLine("Records in DataTable.");
            foreach (var item in table.AsEnumerable())
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " + item.Field<int>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tisLike: " + item.Field<bool>("isLike"));
            }
            return table;
            
        }
        //UC9 - DISPLAYS RECORDS FROM TABLE WHOSE ISLIKE VALUE IS TRUE
        public void IsLikeValueTrue(List<ProductReview> productReviews)
        {
            DataTable table = createDatatable(productReviews);
            var result = (from product in table.AsEnumerable()
                          where product.Field<bool>("isLike") == true
                          select product);
            Console.WriteLine("\nRecords Whose IsLike value is true.\n");
            foreach (var item in result)
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " + item.Field<int>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tisLike: " + item.Field<bool>("isLike"));
            }
        }
    }
}
