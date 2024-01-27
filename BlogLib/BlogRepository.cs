using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace BlogLib
{
    public class BlogRepository
    {
        private readonly BlogDbContext _context;

        public BlogRepository()
        {
            _context = new BlogDbContext();
        }

        public void SaveBlog(BlogInfo blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }

        public void UpdateBlog(BlogInfo blog)
        {
            _context.Entry(blog).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteBlog(int blogId)
        {
            var blog = _context.Blogs.Find(blogId);
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
        }

        public List<BlogInfo> GetAllBlogs()
        {
            return _context.Blogs.ToList();
        }

        public BlogInfo GetBlogById(int blogId)
        {
            return _context.Blogs.Find(blogId);
        }
    }
}
