using System;
using System.Collections.Generic;
using System.Linq;
using EFGetStarted;
using EFModelWalkthrough;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BusinessLayer_EF
{
    public class CrudManager
    {
        public Blog selectedBlog { get; set; }
        static void Main(string[] args)
        {

            //Test to see if creating a blog works
            //var create = new CrudManager();
            //    create.CreateBlog("https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=visual-studio");

            //create.CreateBlog("http://thisissecondblog.com");


            //Test to see if i can retrieve
            //var read = new CrudManager();
            //var all = read.ReadAllBlogs();
            //foreach(var blog in all)
            //{
            //    Console.WriteLine(blog.Url);
            //}    

            //Update Test
            //var update = new CrudManager();
            //update.UpdateABlog(3, "https://updated");

            //Delete a blog
            //var delete = new CrudManager();
            //delete.DeleteABlog(4);

        }

        public void CreateBlog(string url)
        {
            using (var db = new BloggingContext())
            {
                var blog = new Blog();
                blog.Url = url;
                db.Add(blog);
                db.SaveChanges();
            }
        }

        public List<Blog> ReadAllBlogs()
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.ToList();
            }
        }

        public void UpdateABlog(int blogId, string url)
        {
            using (var db = new BloggingContext())
            {
                selectedBlog = db.Blogs.Where(b => b.BlogId == blogId).FirstOrDefault();
                selectedBlog.Url = url;
                db.SaveChanges();
            }
        }

        public void DeleteABlog(int blogId)
        {
            using(var db = new BloggingContext())
            {
                selectedBlog = db.Blogs.Where(b => b.BlogId == blogId).FirstOrDefault();
                db.Blogs.Remove(selectedBlog);
                db.SaveChanges();
            }
        }
    }
}
