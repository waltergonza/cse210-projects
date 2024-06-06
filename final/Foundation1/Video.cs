public class Video
{
    //Atributes
    private string title; 
    private string author;
    private int length;
    private List<Comment>comments;

    //Getter and setter for title:
    public string GetTitle()
    {
        return title;
    }

    public void setTitle(string value)
    {
        title = value;
    }

    //Getter and setter for author:
    public string GetAuthor()
    {
        return author;
    }

    public void setAuthor(string value)
    {
        author = value;
    }

    //Getter and setter for length:
    public int GetLength()
    {
        return length;
    }

    public void setLength(int value)
    {
        length = value;
    }

    //Getter for comments:
    public List<Comment> GetComments()
    {
        return comments;
    }

    //Constructor
    public Video(string title, string author, int length)
    {
        setTitle(title);
        setAuthor(author);
        setLength(length);
        comments = new List<Comment>();
    }

    //Methods
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
}