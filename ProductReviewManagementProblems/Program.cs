using System;
using System.Collections.Generic;

namespace ProductReviewManagementProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Review Management");
            List<ProductReview> productreviews = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=2,UserId=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=3,UserId=2,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductId=4,UserId=3,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductId=5,UserId=3,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductId=6,UserId=2,Rating=1,Review="Good",isLike=true},
                new ProductReview(){ProductId=7,UserId=3,Rating=5,Review="Bad",isLike=false},
                new ProductReview(){ProductId=8,UserId=4,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=9,UserId=5,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=10,UserId=3,Rating=5,Review="Bad",isLike=false},
                new ProductReview(){ProductId=11,UserId=4,Rating=1,Review="Good",isLike=true},
                new ProductReview(){ProductId=12,UserId=5,Rating=1,Review="Good",isLike=true},
                new ProductReview(){ProductId=13,UserId=6,Rating=1,Review="Good",isLike=true},
                new ProductReview(){ProductId=14,UserId=7,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductId=15,UserId=8,Rating=5,Review="Bad",isLike=false},
                new ProductReview(){ProductId=16,UserId=7,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=17,UserId=7,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=18,UserId=6,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=19,UserId=8,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductId=20,UserId=5,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductId=21,UserId=1,Rating=3,Review="Bad",isLike=false},
                new ProductReview(){ProductId=22,UserId=4,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=23,UserId=1,Rating=5,Review="Bad",isLike=false},
                new ProductReview(){ProductId=24,UserId=3,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductId=25,UserId=2,Rating=5,Review="Good",isLike=true},
            };
            //foreach(var list in productreviews)
            //{
            //    Console.WriteLine("ProdcutId:"+list.ProductId+"UserId:"+list.UserId+"Rating:"+list.Rating+"Review:"+list.Review+"isLike:"+list.isLike);
            //}

            Management management = new Management();
            //Console.WriteLine("Top 3 Records Having High Rating");
            //management.Top_Record_Having_High_Rating(productreviews);
            Console.WriteLine("Retrive Record Having Rating Greater Than 3 With ProductId ");
            management.HavingRatingGreaterThan3WthProductId(productreviews);
        }
    }
}
