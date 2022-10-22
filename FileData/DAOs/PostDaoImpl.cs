﻿using Application.DaoInterfaces;
using SharedDomain.DTOs;
using SharedDomain.Models;

namespace FileData.DAOs;

public class PostDaoImpl : IPostDao
{
    private readonly FileContext context;

    public PostDaoImpl(FileContext context)
    {
        this.context = context;
    }
    public Task<Post> CreateAsync(Post post)
    {
        int postId = 1;
        
        if (context.Posts.Any())
        {
            //Looking through all post id s and finding the biggest one
            postId = context.Posts.Max(t => t.id);
            postId++;
        }

        post.id = postId;

        context.Posts.Add(post);
        context.SaveChange();

        return Task.FromResult(post);
    }

    public Task<IEnumerable<Post>> GetAllAsync()
    {
        IEnumerable<Post> result = context.Posts.AsEnumerable();

        return Task.FromResult(result);
    }

    public Task<IEnumerable<Post>?> GetByTitle(string title)
    {
        IEnumerable<Post> post = context.Posts.Where(p => p.title.Equals(title,StringComparison.OrdinalIgnoreCase));
        if (!post.Any())
        {
            throw new Exception($"Post with title: {title} doesn't exist");
        }

        return Task.FromResult(post);
    }
}