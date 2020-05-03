using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_FRAMEWORK2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ENTITY_FRAMEWORK2020Entities2();
            var post = new Post()
            {
                Body = "Body",
                DatePublished = DateTime.Now,
                Title = "Neo",
                PostID = 1
            };
            context.Posts.Add(post);
            context.SaveChanges();

        }
    }
}
