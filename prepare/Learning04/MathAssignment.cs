using System.Security.Cryptography.X509Certificates;

public class MathAssignment: Assigment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }

    public string GetHomeworkList()
    {
        return $"\n{_studentName} - {_topic} \nSection {_textbookSection} Problems {_problems}";
    }
}