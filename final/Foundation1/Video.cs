public class Video
{
    private string _author;
    private string _title;
    private int _length;
    private List<Comment> _comments;

    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments = new List<Comment>();

    }
    public void AddComment(string author, string comment)
    {
        Comment newComment = new Comment(author, comment);
        _comments.Add(newComment);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author : {_author}");
        Console.WriteLine($"Length : {_length}");
        Console.WriteLine($"Number of comments: {GetCommentNumber()}");
    }
    public void DisplayVideoComment()
    {
        Console.WriteLine("Comments");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommenterName()} {comment.GetComment()}");
        }

    }


    public string GetAuthor()
    {
        return _author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public int GetLength()
    {
        return _length;
    }
    public int GetCommentNumber()
    {
        return _comments.Count();
    }
}