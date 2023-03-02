public class Activity{
    private int _duration;
    private List<string> _animation = new List<string>(){
        "('o')","(o:)","(.o.)","(:o)"
    };

    public void DisplayWelcome(string discription, string name){
        Console.WriteLine($"Welcome to the {name}.");
        DisplayAnimation(1);
        Console.WriteLine(discription);
        DisplayAnimation(3);
    }
    public void DisplayEnd(string name){
        DisplayAnimation(1);
        Console.WriteLine("Well Done!");
        DisplayAnimation(1);
        Console.WriteLine($"You have completed another {_duration} seconds of the {name}.");
        DisplayAnimation(4);
        Console.Clear();
    }
    public void DisplayAnimation(int timeRange){
        for(int t = 0; t < timeRange; t++){
            foreach(string frame in _animation){
                Console.Write(frame);
                Thread.Sleep(250);
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            }
        }     
        Console.WriteLine();
    }
    public void DisplayCountdown(int timerLength){
        for(int t = timerLength; t > 0; t--){
            Console.Write(t);
            Thread.Sleep(1000);
            if(t < 10){
                Console.Write("\b \b");
            }
            else{
                Console.Write("\b\b \b");
            }
        }
        Console.WriteLine();
    }
    public void SetDuration(){
        Console.Write("How Long, in seconds, would you like for your session? ");
        string userEntry = Console.ReadLine();
        int seconds = int.Parse(userEntry);
        _duration = seconds;
    }
    public int GetDuration(){
        return _duration;
    }
    public int GetReandIndex(int range){
        Random random = new Random();
        int randInt = random.Next(range);
        return randInt;
    }
}