using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducyReviewManagement
{
    internal class ProductReviewManagment
    {
        public void TopRecord(List<ProductReview> productslist)
        {
            var topRecord = (from record in productslist orderby record.Rating descending select record).Take(3);
            Console.WriteLine("\n-------Top 3 Reviews-------");
            foreach (var item in topRecord)
            {
                Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
            }
        }
    }
}
