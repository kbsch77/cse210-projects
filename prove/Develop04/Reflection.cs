public class Reflection : Activity{
    private string _name = "Reflection Activity";
    private string _description = 
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _usedPrompts = new List<string>(){};
    private List<string> _usedQuestions = new List<string>(){};
        
    public Reflection(): base(){}

    public void DisplayReflection(){
        Console.Clear();
        DisplayWelcome(_description, _name);
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayAnimation(3);

        int time = (GetDuration() / 7) + 1;

        DisplayRandPrompt();
        Console.WriteLine("Now ponsider on each of the following questions as they relate to your experiance.");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.Clear();

        for(int t = 0; t < time; t++){
            DisplayRandQuestion();
        }
        DisplayEnd(_name);
    }
    private void DisplayRandPrompt(){
        int index;
        do{
            index = GetRandIndex(_prompts.Count);
        }while(CompareUsedPrompts(index));
        _usedPrompts.Add(_prompts[index]);

        Console.WriteLine("Consider the following prompt:");
        DisplayAnimation(1);
        Console.WriteLine($"--- {_prompts[index]} ---");
        DisplayAnimation(3);
        Console.WriteLine("When you have something in mind, press enter to contine.");
        Console.ReadLine();
    }
    private void DisplayRandQuestion(){
        int index;
        do{
            index = GetRandIndex(_questions.Count);
        }while(CompareUsedQuestions(index));
        _usedQuestions.Add(_questions[index]);
        
        Console.WriteLine($"> {_questions[index]}");
        DisplayAnimation(7);
    }
    private bool CompareUsedPrompts(int index){
        if(_usedPrompts.Count == _prompts.Count){
            _usedPrompts.Clear();
        }

        if(_usedPrompts.Contains(_prompts[index])){
            return true;
        }
        else{
            return false;
        }
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