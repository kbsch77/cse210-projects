public class Resume{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
    public void DisplayResume(){
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterates through the job list and displays every Job's info
        foreach (Job job in _jobs){
            job.DisplayJobDetails();
        }
    }
}