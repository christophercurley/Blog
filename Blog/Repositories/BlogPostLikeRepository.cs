﻿using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog.Repositories
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        private readonly BlogDbContext blogDbContext;

        public BlogPostLikeRepository(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }

        public async Task<int> GetTotalLikes(Guid blogPostId)
        {
            return await blogDbContext.BlogPostLikes.CountAsync(x => x.BlogPostId == blogPostId);
        }
    }
}
