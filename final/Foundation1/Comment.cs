public class Comment
{
    //Attributes
    private string commenterName;
    private string text;

    //Getter and setter for commenterName:
    public string GetCommenterName()
    {
        return commenterName;
    }

    public void SetCommenterName(string value)
    {
        commenterName = value;
    }

    //Getter and setter for text:
    public string GetText()
    {
        return text;
    }

    public void SetText(string value)
    {
        text = value;
    }

    //Constructor
    public Comment(string comenterName, string text)
    {
        SetCommenterName(comenterName);
        SetText(text);
    }
}