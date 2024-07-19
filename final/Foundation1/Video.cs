namespace Foundation1;

public class Video()
{
    public string _videoTitle;
    public string _author;
    public int _videoDuration;
    public List<Comment> _comments = new();

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_videoTitle}\nAuthor: {_author}\nDuration: {_videoDuration} second(s)");
        Console.WriteLine($"{GetNumberOfComments()} comment(s):");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public List<Video> _videos = new List<Video>();

    public void DisplayAllVideos()
    {
        foreach (Video v in _videos)
        {
            v.DisplayVideoInfo();
        }
    }
}