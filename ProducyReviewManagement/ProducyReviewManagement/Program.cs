namespace ProducyReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Product Review Management");

            List<ProductReview> productList = new List<ProductReview>()
            { 
                new ProductReview() {ProductId =  1,UserId = 1, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId =  2,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  3,UserId = 3, Rating = 3.5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  4,UserId = 6, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId =  5,UserId = 2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  6,UserId = 3, Rating = 3, Review = "Average", IsLike = true},
                new ProductReview() {ProductId =  7,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  8,UserId = 2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  9,UserId = 1, Rating = 1, Review = "Verybad", IsLike = false},
                new ProductReview() {ProductId = 4,UserId = 5, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 1,UserId = 5, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 2,UserId = 1, Rating = 3, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 4,UserId = 2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 4,UserId = 4, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 1,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 6,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 7,UserId = 3, Rating = 2.5, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 9,UserId = 3, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId = 9,UserId = 6, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 2,UserId = 6, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId = 3,UserId = 4, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 1,UserId = 3, Rating = 3, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 5,UserId = 2, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 4,UserId = 5, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 5,UserId = 2, Rating = 4.5, Review = "VeryGood", IsLike = true},
            };
            Console.WriteLine("\n-------Product Review-------");
            foreach(var item in productList)
            {
                Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
            }
            ProductReviewManagment productReviewManagment = new ProductReviewManagment();
            productReviewManagment.TopRecord(productList);
            productReviewManagment.SellectedRecord(productList);
            productReviewManagment.CountReviewOfProductId(productList);
            productReviewManagment.RetriveProductIdAndReview(productList);
            productReviewManagment.SkipTop5Record(productList);
            productReviewManagment.ProductIdAndReview(productList);

            DataBaseOperation dataBaseOperation = new DataBaseOperation();
            dataBaseOperation.CreateDataTable();
            dataBaseOperation.RetrieveIsLikeValueWithTrue();
            dataBaseOperation.AvgRatingOfProductId();
        }
    }
}