public class Options
{
    public String _select = "";
    public String _options = "";

    public int _choice = 0;

    public void DisplayInfo(){

        Console.WriteLine(_select);
        Console.WriteLine(_options);
        Console.Write("What would you like to do? ");
        String response = Console.ReadLine();
        _choice = int.Parse(response);
    }

    public String NameOfFile (){
        Console.Write("Plasea enter the name of a file: ");
        String name = Console.ReadLine();
        return name;
    }
}

