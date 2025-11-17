using System.Runtime.CompilerServices;

public class Video
{
  private string _title;
  private string _author;
  private int _length;
  private List<Comment> _comments;
  private List<string> emptyList = new List<string>();

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
  }

  public string GetVideoDetails()
  {
    string videoDetails = _author + " - " + _title + ", " + _length + "s";
    return videoDetails;
  }

  public List<Comment> GetMoreComments()
  {
    Comment comments1 = new Comment(emptyList, emptyList);
    Comment comments2 = new Comment(emptyList, emptyList);
    Comment comments3 = new Comment(emptyList, emptyList);
    Comment comments4 = new Comment(emptyList, emptyList);
    Comment comments5 = new Comment(emptyList, emptyList);
    _comments.Add(comments1);
    _comments.Add(comments2);
    _comments.Add(comments3);
    _comments.Add(comments4);
    _comments.Add(comments5);
    return _comments;
  }

  public void DisplayVideoAndComments()
  {
    Console.WriteLine(GetVideoDetails());
    foreach (Comment _comment in GetMoreComments())
    {
      Console.WriteLine(_comment);
    }
  }
}