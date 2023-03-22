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
    }
}
