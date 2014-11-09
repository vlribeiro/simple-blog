using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SimpleBlog.Util;

namespace SimpleBlog.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogDBContext>
    {
        /// <summary>
        /// Creates the initial seed to the database, adding any necessary values to the tables
        /// </summary>
        /// <param name="context">The context in which to generate the data</param>
        protected override void Seed(BlogDBContext context)
        {
            base.Seed(context);

            var users = new List<User>
            {
                new User { FirstName = "Vinícius", LastName = "Ribeiro", Username = "vlribeiro", Password = "12345".SHA256(), Bio = "A standard bio.", Email = "vl.ribeiro3@gmail.com", CreatedAt = DateTime.Now }
            };

            foreach (var user in users)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}