public class WritingAssignment : Assignment{
 private string _title;

 public WritingAssignment(string name, string topic, string title)  : base(name, topic){
    _studentName = name;
    _topic = topic;
    _title = title;
 }

 public string GetWritingInformation(){
    string information = (_topic + " by " + _studentName);
    return information;
 }   
}