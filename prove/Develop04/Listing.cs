public class Listing : Activity{
    private string _name = "Listing Activity";
    private string _description = 
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _questions = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _usedQuestions = new List<string>(){};
    private int _counter;
    private DateTime startTime;
    private DateTime futureTime;
    private DateTime currentTime;

    public Listing(): base(){}

    public void DisplayListing(){
        Console.Clear();
        DisplayWelcome(_description, _name);
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayAnimation(3);

        int time = GetDuration();

        DisplayRandQuestion();
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(time);

        _counter = 0;
        while(currentTime <= futureTime){
            Console.Write("> ");
            Console.ReadLine();
            _counter ++;
            currentTime = DateTime.Now;
        }
        DisplayCounter();
        DisplayEnd(_name);
    }
     private void DisplayRandQuestion(){
        int index;
        do{
            index = GetRandIndex(_questions.Count);
        }while(CompareUsedQuestions(index));
        _usedQuestions.Add(_questions[index]);

        Console.WriteLine("List as many responces you can to the following prompt:");
        Console.WriteLine($"--- {_questions[index]} ---");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
    }
    private void DisplayCounter(){
        Console.WriteLine($"You listed {_counter} items!");
    }
    private bool CompareUsedQuestions(int index){
        if(_usedQuestions.Count == _questions.Count){
            _usedQuestions.Clear();
        }

        if(_usedQuestions.Contains(_questions[index])){
            return true;
        }
        else{
            return false;
        }
    }
}