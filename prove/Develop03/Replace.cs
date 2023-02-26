public class Replace{

    private Random _random = new Random();

    public void HideWords (String [] _words, String refe) {

        for (int i = 0; i < _words.Length; i++){

            if (_random.Next(3) == 0){

                _words[i] = new String ('_', _words[i].Length);

            }
        }

        String finalVers = (String.Join(" ", _words));
        Console.WriteLine($"{refe} - {finalVers}");


    }


}

