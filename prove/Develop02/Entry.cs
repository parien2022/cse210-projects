public class Entry
{
    public Random _random = new Random();
    public List<String> _list = new List<string>{};
    public String _date = "";
    public String _prompt = "";
    public String _answer = "";
    public void DisplayRandom (){
        int listOption = _random.Next(_list.Count);
        _prompt = (_list[listOption]);
        Console.WriteLine(_prompt);
        _answer = Console.ReadLine();
    }
}