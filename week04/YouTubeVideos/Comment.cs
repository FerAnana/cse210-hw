using System.ComponentModel.Design.Serialization;
using System.Linq;

public class Comment
{

  private string _name;
  private string _comment;
  private Random _selector = new Random();
  public Comment(List<string> names, List<string> comments)
  {
    names = new List<string>
    {
      "Fernando",
      "Sophia",
      "Gonzalo",
      "James",
      "Mel",
      "Ariel",
      "Randy",
      "Melina",
      "Charly",
      "George",
    }
    ;

    comments = new List<string>
    {
      "Boring",
      "Wow! That was great!",
      "Very interesting.",
      "I love chess!",
      "I don't like this type of content",
      "Messi is the GOAT!",
      "I would do this recipe!",
      "I could sleep very well with this as background",
      "Haha, same",
      "Yooo, I'm going to subscribe",
    }
    ;

    int randomName = _selector.Next(0, names.Count());
    _name = names[randomName];

    int randomComment = _selector.Next(0, comments.Count());
    _name = names[randomName];
    _comment = comments[randomComment];
  }
  
  public string GetComment()
  {
    string fullComment = _name + ": " + _comment;
    return fullComment;
  }
}