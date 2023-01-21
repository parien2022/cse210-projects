public class Resume
{
    public String _personName = "";
    public List<Job> _jobList = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs: ");
        foreach (Job item in _jobList){
            item.Display();
        }
    }

}