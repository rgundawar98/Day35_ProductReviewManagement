using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProblems
{
    public class Management
    {
        public void Top_Record_Having_High_Rating(List<ProductReview> Reviews)
        {
            var recordData = (from Productreviews in Reviews
                              orderby Productreviews.Rating descending
                              select Productreviews).Take(3);
            foreach(var record in recordData)
            {
                Console.WriteLine("ProductId:"+record.ProductId+"UserId:"+record.UserId+"Rating:"+record.Rating);
            }
        }

        public void HavingRatingGreaterThan3WthProductId(List<ProductReview> Reviews)
        {
            var recordData=(from Productreview in Reviews
                            where (Productreview.ProductId == 1 && Productreview.Rating > 3)||
                            (Productreview.ProductId == 4 && Productreview.Rating > 3) ||
                            (Productreview.ProductId == 9 && Productreview.Rating > 3)
                            select Productreview);
            foreach(var record in recordData)
            {
                Console.WriteLine("ProductId:" + record.ProductId + " UserId:" + record.UserId+" Rating:"+record.Rating+" Review:"+record.Review+" isLike:"+record.isLike);
            }
        }

        public void Retrive_Count_of_Records(List<ProductReview> Reviews)
        {
            var recordData = Reviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count()});
            foreach(var record in recordData)
            {
                Console.WriteLine("For ProductId: " + record.ProductId + " records will be:" + record.Count);
            }
        }

        public void Retrive_Count_Of_ProductID(List<ProductReview> Reviews)
        {
            var recordData = Reviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key });
            foreach(var record in recordData)
            {
                Console.WriteLine("ProductId:" + record.ProductId);
            }
        }

        public void Skip_Five_Records(List<ProductReview> listofrecord)
        {
            var recordData = listofrecord.Skip(5).ToList();
            foreach(var record in recordData)
            {
                Console.WriteLine("ProductId:"+record.ProductId+" UserId"+record.UserId+" Rating:"+record.Rating+" Review:"+record.Review+" isLike:"+record.isLike);
            }
        }

        public void Retrive_ProductId_And_Reviews(List<ProductReview> listofrecord)
        {
            var recordData=listofrecord.Select(x=> new {productId=x.ProductId, Review=x.Review});
            foreach(var record in recordData)
            {
                Console.WriteLine("ProductId:"+record.productId+" Review:"+record.Review);
            }
        }

        public void Retrive_Records_isLike_True(List<DataTable> listofrecord)
        {
            var records = listofrecord.Where(x => x.isLike==true).OrderBy(x=>x.isLike).ToList();
            foreach(var record in records)
            {
                Console.WriteLine(record.isLike);
            }
        }
    }
}
