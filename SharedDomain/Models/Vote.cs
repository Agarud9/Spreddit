namespace SharedDomain.Models;

public class Vote
{
    public string Username { get; set; }
    public VoteType Type { get; set; }
}

public enum VoteType
{
    DownVote = -1,
    UpVote = 1
}