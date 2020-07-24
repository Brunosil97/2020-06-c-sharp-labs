using System;
using System.Collections.Generic;
using System.Linq;
using EFGetStarted;
using EFModelWalkthrough;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BusinessLayer_EF
{
    public class CrudManager
    {
        public Blog selectedBlog { get; set; }
        public Post selectedPost { get; set; }
        static void Main(string[] args)
        {
        }

        public void CreateBlog(string url, string author)
        {
            using (var db = new BloggingContext())
            {
                var blog = new Blog();
                blog.Url = url;
                blog.Author = author;
                db.Add(blog);
                db.SaveChanges();
            }
        }

        public void CreatePost(int blogId, string title, string context)
        {
            using (var db = new BloggingContext())
            {
                var post = new Post();
                post.BlogId = blogId;
                post.Title = title;
                post.Content = context;
                db.Add(post);
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

        public List<Post> ReadAllPosts(int blogId)
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.Where(b => b.BlogId == blogId).Include(p => p.Posts).FirstOrDefault().Posts.ToList();
                   //db.Posts.Where(p => p.BlogId == blogId).ToList();
            }
        }

        public void UpdateABlog(int blogId, string url, string author)
        {
            using (var db = new BloggingContext())
            {
                selectedBlog = db.Blogs.Where(b => b.BlogId == blogId).FirstOrDefault();
                selectedBlog.Url = url;
                selectedBlog.Author = author;
                db.SaveChanges();
            }
        }

        public void UpdateAPost(int postId, string title, string context)
        {
            using(var db = new BloggingContext())
            {
                selectedPost = db.Posts.Where(p => p.PostId == postId).FirstOrDefault();
                selectedPost.Title = title;
                selectedPost.Content = context;
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

        public void SetSelectedBlog(object selectedItem)
        {
            selectedBlog = (Blog)selectedItem;
        }

        public void setSelectedPost(object selectedItem)
        {
            selectedPost = (Post)selectedItem;
        }
    }
}
