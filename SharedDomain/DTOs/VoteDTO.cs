﻿namespace SharedDomain.DTOs;

/// <summary>
/// Data transfer object for upvoting/downvoting.
/// </summary>
public class VoteDTO
{
    /// <summary>
    /// Username who vote on the post.
    /// </summary>
    public string? Username { get; set; }
    /// <summary>
    /// Id of the post which the user wants to vote on.
    /// </summary>
    public int PostId { get; set; }
}