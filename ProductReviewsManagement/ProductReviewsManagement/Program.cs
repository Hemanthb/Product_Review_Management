Console.WriteLine("Enter your choice\n\t1 - To Fetch Top 3 High rated records\n\t" +
    "2 - Retrieve Products with rating higher then 3\n\t3 - To get count of reviews for a product ID\n");
int choice = Convert.ToInt32(Console.ReadLine());
ProductReviewsManagement.ReviewsManagement reviewsManagement = new ProductReviewsManagement.ReviewsManagement();
/* ------- ADDS DEFAULT DATA INTO PRODUCT REVIEWS LIST ------- */
    
    List<ProductReviewsManagement.ProductReview> reviews = new List<ProductReviewsManagement.ProductReview>()
    {
        new ProductReviewsManagement.ProductReview() { ProductId = 1, UserId = 1, Rating = 2, Review = "Average", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 2, UserId = 2, Rating = 1.5, Review = "Bad", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "Nice", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 4, UserId = 4, Rating = 4.5, Review = "Good", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 5, UserId = 5, Rating = 5, Review = "Excelent", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 6, UserId = 3, Rating = 3, Review = "Nice", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 7, UserId = 6, Rating = 2, Review = "Average", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 7, UserId = 5, Rating = 1, Review = "Bad", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 9, UserId = 10, Rating = 4, Review = "Good", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 1, UserId = 23, Rating = 5, Review = "Excelent", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 11, UserId = 5, Rating = 4, Review = "Nice", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 12, UserId = 4, Rating = 1, Review = "Very Bad", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 13, UserId = 12, Rating = 5, Review = "Excelent", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 7, UserId =17, Rating = 2.5, Review = "Average", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 15, UserId = 10, Rating = 3, Review = "Nice", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 16, UserId = 8, Rating = 1, Review = "Very Bad", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 17, UserId = 18, Rating = 5, Review = "Excelent", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 18, UserId = 9, Rating = 4, Review = "Good", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 19, UserId = 10, Rating = 5, Review = "Nice", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 20, UserId = 7, Rating = 2, Review = "Average", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 21, UserId = 6, Rating = 1, Review = "Bad", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 22, UserId = 5, Rating = 1, Review = "Very Bad", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 23, UserId = 10, Rating = 4, Review = "Good", isLike = false },
        new ProductReviewsManagement.ProductReview() { ProductId = 24, UserId = 8, Rating = 1.5, Review = "Bad", isLike = true },
        new ProductReviewsManagement.ProductReview() { ProductId = 25, UserId = 12, Rating = 2, Review = "Average", isLike = false },
    };
    foreach (var item in reviews)
    {
        Console.WriteLine(item.ProductId +" - "+item.UserId+" - "+item.Rating);
    }
switch (choice)
{
    case 1:
        reviewsManagement.GetHighReviews(reviews);
        break;
    case 2:
        reviewsManagement.RatingsGreaterThanThree(reviews);
        break;
    case 3:
        reviewsManagement.countOFReviewForProductID(reviews);
        break;

}

