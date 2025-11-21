using System.Globalization;
using System.Runtime.CompilerServices;

public class Video
{
  private string _title;
  private string _author;
  private int _length;
  private List<string> _comments;
  private List<string> emptyList = new List<string>();

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;

    _comments = new List<string>();
  }

  public string GetVideoDetails()
  {
    string videoDetails = $"{_author} - {_title}, {_length}s";
    return videoDetails;
  }

  public List<string> GetMoreComments()
  {
    Comment comments1 = new Comment(emptyList, emptyList);
    Comment comments2 = new Comment(emptyList, emptyList);
    Comment comments3 = new Comment(emptyList, emptyList);
    Comment comments4 = new Comment(emptyList, emptyList);
    Comment comments5 = new Comment(emptyList, emptyList);
    string fullComment1 = comments1.GetComment();
    string fullComment2 = comments2.GetComment();
    string fullComment3 = comments3.GetComment();
    string fullComment4 = comments4.GetComment();
    string fullComment5 = comments5.GetComment();
    _comments.Add(fullComment1);
    _comments.Add(fullComment2);
    _comments.Add(fullComment3);
    _comments.Add(fullComment4);
    _comments.Add(fullComment5);
    return _comments;
  }

  public int numComents()
  {
    return _comments.Count();
  }
  public void DisplayVideoAndComments()
  {
    Console.WriteLine($"{GetVideoDetails()}\n");
    foreach (string _comments in GetMoreComments())
    {
      Console.WriteLine(_comments);
    }
    Console.WriteLine($"\nTotal of comments: {numComents()}\n");
  }
}