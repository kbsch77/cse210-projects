public class Breathing : Activity{
    private string _name = "Breathing Activity";
    private string _description = 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public Breathing(): base(){}

    public void DisplayBreathing(){
        Console.Clear();
        DisplayWelcome(_description, _name);
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayAnimation(3);

        int time = (GetDuration() / 12) + 1;

        for(int t = 0; t < time; t++){
            Console.Write("Breathe in...");
            DisplayCountdown(6);
            Console.Write("Out in...");
            DisplayCountdown(6);
            Console.WriteLine();
        }
        DisplayEnd(_name);
    }
}