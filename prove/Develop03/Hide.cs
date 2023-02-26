public class Hide {

    private String [] _splitedVers;
    private String _input = "";

    public void Split (String refe, String vers, Replace replace){

        _splitedVers = vers.Split(" ");

        Console.WriteLine($"{refe} - {vers}");

        while (_input.ToLower() != "quite") {
            
            Console.Write("Please press enter or type 'quite': ");
            _input = Console.ReadLine();

            if (_input.ToLower() == "quit"){

                break;

            } else{

                Console.Clear();
                replace.HideWords(_splitedVers, refe);
                

            }
        }

    }
}