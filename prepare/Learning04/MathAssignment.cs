public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic){
        _studentName = name;
        _topic = topic;
        _textbookSection = textbook;
        _problems = problems;
    }
    public string GetHomeworkList(){
        string homework = ("Section " + _textbookSection + " Problems " + _problems);
        return homework;
    }
}