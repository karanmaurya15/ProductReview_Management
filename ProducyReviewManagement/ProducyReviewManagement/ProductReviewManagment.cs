﻿using System;
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
            var records = (from record in productslist orderby record.Rating descending select record).Take(3);
            Console.WriteLine("\n-------Top 3 Reviews-------");
            foreach (var item in records)
            {
                Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
            }
        }
        public void SellectedRecord(List<ProductReview> productlist)
        {
            var records = (from record in productlist where (record.ProductId == 1 || record.ProductId == 4 || record.ProductId == 9) && record.Rating > 3 select record);
            Console.WriteLine("\n-------Rating grater than 3-------");
            foreach (var item in records)
            {
                Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
            }
        }
        public void CountReviewOfProductId(List<ProductReview> productslist)
        {
            var records = productslist.GroupBy(x => x.ProductId).Select(e => new { ProductId = e.Key, Count = e.Count() });
            Console.WriteLine("\n-------Count Review of Product-------");
            foreach (var item in records)
            {
                Console.WriteLine($"Product Id : {item.ProductId}, " + $"Count  : {item.Count}");
            }
        }
        public void RetriveProductIdAndReview(List<ProductReview> productlist)
        {
            var records = productlist.Select(e => new { ProductId = e.ProductId, Review = e.Review });
            Console.WriteLine("\n-------Retrive only Product Id and Review------");
            foreach (var item in records)
            {
                Console.WriteLine($"Product Id : {item.ProductId}, " + $"Review : {item.Review}");
            }
        }
        public void SkipTop5Record(List<ProductReview> productlist)
        {
            var records = (from record in productlist select record).Skip(5);
            Console.WriteLine("\n-------Skip top 5 Records-------");
            foreach (var item in records)
            {
                Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
            }
        }
        public void ProductIdAndReview(List<ProductReview> productlist)
        {
            var records = productlist.Select(e => new { e.ProductId, e.Review });
            Console.WriteLine("\n-------Retrive only Product Id and Review------");
            foreach (var item in records)
            {
                Console.WriteLine($"Product Id : {item.ProductId}, " + $"Review : {item.Review}");
            }
        }
        public void RetrieveReviewMessage(List<ProductReview> productlist)
        {
            var records = productlist.Where(x => x.Review.Contains("Nice")).ToList();
            Console.WriteLine("\n-------Review Message-------");
            foreach(var item in records)
            {
                Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
            }
        }
    }
}
